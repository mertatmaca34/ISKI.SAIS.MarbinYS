using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Threading.Tasks;
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
    // Stores the last time a notification mail was sent to a user so that we
    // don't spam the same recipient repeatedly. Keyed only by user id to apply
    // cooldown regardless of which alarm was triggered.
    private readonly Dictionary<int, DateTime> _lastSentTimes = new();

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

                    if (analogVal.HasValue)
                        triggered = analogVal.Value > item.Alarm.Limit;
                    else if (digitalVal.HasValue)
                        triggered = digitalVal.Value;
                    else
                        continue;

                    if (!triggered)
                        continue;

                    // Skip sending if the last mail to this user was within the cooldown period
                    if (_lastSentTimes.TryGetValue(item.UserId, out var last) &&
                        DateTime.UtcNow - last < TimeSpan.FromMinutes(cooldownMinutes))
                        continue;

                    var subject = item.Alarm.MailSubject;
                    var bodyValue = analogVal?.ToString("F2") ?? (digitalVal?.ToString() ?? string.Empty);
                    var body = item.Alarm.MailBody.Replace("{value}", bodyValue);

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
                        Body = body
                    };
                    mail.To.Add(item.Email);

                    await client.SendMailAsync(mail, stoppingToken);
                    // Warn so the event stands out in the logs since it indicates an abnormal condition
                    logger.LogWarning(
                        "Alarm {Alarm} triggered for user {Email} with value {Value}. E-mail sent.",
                        item.Alarm.Name,
                        item.Email,
                        bodyValue);
                    _lastSentTimes[item.UserId] = DateTime.UtcNow;
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error while processing mail alarms");
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
}
