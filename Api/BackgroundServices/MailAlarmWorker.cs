using System;
using Api.Constants;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Api.Helpers;
using Domain.Enums;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Api.BackgroundServices;

/// <summary>
/// Periodically checks alarm conditions and sends notification e-mails.
/// </summary>
public class MailAlarmWorker(
    IServiceProvider serviceProvider,
    IConfiguration configuration,
    ILogger<MailAlarmWorker> logger) : BackgroundService
{
    // Stores the last time a notification mail was sent for a user/alarm pair
    // so that a triggered alarm doesn't suppress other simultaneous alarms
    // for the same user. The key is composed of both the user id and the alarm id.
    private readonly Dictionary<(int UserId, int AlarmId), DateTime> _lastSentTimes = new();

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        int intervalSeconds = configuration.GetValue<int>("AlarmSettings:CheckIntervalSeconds", 5);
        int cooldownMinutes = configuration.GetValue<int>("AlarmSettings:EmailCooldownMinutes", 1);
        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                using var scope = serviceProvider.CreateScope();
                var context = scope.ServiceProvider.GetRequiredService<IBKSContext>();

                var mailSetting = await context.MailSettings.FirstOrDefaultAsync(stoppingToken);
                if (mailSetting is null)
                {
                    await Task.Delay(TimeSpan.FromSeconds(intervalSeconds), stoppingToken);
                    continue;
                }

                var latestAnalog = await context.AnalogSensorData
                    .OrderByDescending(x => x.Readtime)
                    .FirstOrDefaultAsync(stoppingToken);
                var latestDigital = await context.DigitalSensorData
                    .OrderByDescending(x => x.ReadTime)
                    .FirstOrDefaultAsync(stoppingToken);
                var latestSendData = await context.SendData
                    .OrderByDescending(x => x.Readtime)
                    .FirstOrDefaultAsync(stoppingToken);
                var station = await context.Stations
                    .OrderBy(x => x.Id)
                    .FirstOrDefaultAsync(stoppingToken);

                var query = from ua in context.UserMailAlarms
                            where ua.IsActive
                            join u in context.Users on ua.UserId equals u.Id
                            join a in context.MailAlarms on ua.MailAlarmId equals a.Id
                            select new { ua.UserId, u.Email, Alarm = a };

                var items = await query.ToListAsync(stoppingToken);
                foreach (var item in items)
                {
                    bool triggered = false;
                    double? analogVal = GetAnalogValue(item.Alarm.Channel, latestAnalog);
                    bool? digitalVal = GetDigitalValue(item.Alarm.Channel, latestDigital);
                    bool? invalidStatusVal = GetInvalidStatusValue(item.Alarm.Channel, latestSendData);

                    if (analogVal.HasValue)
                        triggered = analogVal.Value > item.Alarm.Limit;
                    else if (digitalVal.HasValue)
                        triggered = digitalVal.Value;
                    else if (invalidStatusVal.HasValue)
                        triggered = invalidStatusVal.Value;
                    else
                        continue;

                    if (!triggered)
                        continue;

                    // Skip sending if the last mail for this user and alarm was within the cooldown period
                    var key = (item.UserId, item.Alarm.Id);
                    if (_lastSentTimes.TryGetValue(key, out var last) &&
                        DateTime.UtcNow - last < TimeSpan.FromMinutes(cooldownMinutes))
                        continue;

                    var subject = item.Alarm.MailSubject;
                    var measurementValue = analogVal?.ToString("F2")
                        ?? (digitalVal.HasValue
                            ? (digitalVal.Value ? "Aktif" : "Pasif")
                            : (invalidStatusVal.HasValue ? (invalidStatusVal.Value ? "Aktif" : "Pasif") : string.Empty));
                    var limitValue = analogVal.HasValue ? item.Alarm.Limit.ToString("F2") : "-";
                    var severity = item.Alarm.TemplateType == MailTemplateType.Info
                        ? "Bilgi"
                        : invalidStatusVal.HasValue ? "Hata" : "Alarm";
                    var body = MailTemplateBuilder.Build(
                        templateType: item.Alarm.TemplateType,
                        alarmName: item.Alarm.Name,
                        severity: severity,
                        stationName: station?.Name ?? "-",
                        timestamp: DateTime.UtcNow,
                        parameterName: item.Alarm.Name,
                        measuredValue: measurementValue,
                        unit: string.Empty,
                        limit: limitValue,
                        description: item.Alarm.MailBody,
                        sampleTaken: "-",
                        sampleId: "-",
                        nextSampleAt: "-",
                        alarmId: item.Alarm.Id.ToString());

                    using var client = new SmtpClient(mailSetting.SmtpHost, mailSetting.SmtpPort)
                    {
                        EnableSsl = mailSetting.UseSsl,
                        UseDefaultCredentials = mailSetting.UseDefaultCredentials,
                        Credentials = new NetworkCredential(mailSetting.SmtpUser, mailSetting.SmtpPassword)
                    };
                    var mail = new MailMessage
                    {
                        From = new MailAddress(mailSetting.SenderEmail, mailSetting.SenderName),
                        Subject = subject,
                        Body = body,
                        IsBodyHtml = true,
                        BodyEncoding = Encoding.UTF8
                    };
                    mail.To.Add(item.Email);

                    await client.SendMailAsync(mail, stoppingToken);
                    // Warn so the event stands out in the logs since it indicates an abnormal condition
                    logger.LogWarning(
                        LogMessages.MailAlarmWorker.AlarmTriggered,
                        item.Alarm.Name,
                        item.Email,
                        measurementValue);
                    _lastSentTimes[key] = DateTime.UtcNow;
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, LogMessages.MailAlarmWorker.ProcessingError);
            }

            await Task.Delay(TimeSpan.FromSeconds(intervalSeconds), stoppingToken);
        }
    }

    private static double? GetAnalogValue(string channel, Domain.Entities.AnalogSensorData? data)
        => channel switch
        {
            "Akm" => data?.Akm,
            "Koi" => data?.Koi,
            "CozunmusOksijen" => data?.CozunmusOksijen,
            "Iletkenlik" => data?.Iletkenlik,
            _ => null
        };

    private static bool? GetDigitalValue(string channel, Domain.Entities.DigitalSensorData? data)
    {
        if (data is null)
            return null;
        var prop = typeof(Domain.Entities.DigitalSensorData).GetProperty(channel);
        if (prop is null || prop.PropertyType != typeof(bool))
            return null;
        return (bool)prop.GetValue(data)!;
    }

    private static bool? GetInvalidStatusValue(string channel, Domain.Entities.SendData? data)
    {
        if (data is null)
            return null;

        var prop = typeof(Domain.Entities.SendData).GetProperty(channel);
        if (prop is null || prop.PropertyType != typeof(bool))
            return null;

        return (bool)prop.GetValue(data)!;
    }
}
