using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using WinUI.Constants;
using WinUI.Models;

namespace WinUI.Services;

public class MissingDataResendService : BackgroundService
{
    private static readonly TimeSpan Interval = TimeSpan.FromMinutes(10);
    private readonly ISaisApiService _saisApiService;
    private readonly IStationService _stationService;
    private readonly ISendDataService _sendDataService;
    private readonly ILogger<MissingDataResendService> _logger;

    public MissingDataResendService(
        ISaisApiService saisApiService,
        IStationService stationService,
        ISendDataService sendDataService,
        ILogger<MissingDataResendService> logger)
    {
        _saisApiService = saisApiService;
        _stationService = stationService;
        _sendDataService = sendDataService;
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                await ProcessMissingDatesAsync(stoppingToken);
            }
            catch (OperationCanceledException) when (stoppingToken.IsCancellationRequested)
            {
                break;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, LogMessages.MissingDataResendService.UnexpectedError);
            }

            try
            {
                await Task.Delay(Interval, stoppingToken);
            }
            catch (TaskCanceledException)
            {
                // cancellation requested, exit loop on next iteration
            }
        }
    }

    private async Task ProcessMissingDatesAsync(CancellationToken cancellationToken)
    {
        var station = await _stationService.GetFirstAsync();
        if (station is null)
        {
            _logger.LogWarning(LogMessages.PlcDataSendService.StationInfoNotFound);
            return;
        }

        ResultStatus<MissingDatesDto>? response;
        try
        {
            response = await _saisApiService.GetMissingDatesAsync(station.StationId);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, LogMessages.MissingDataResendService.MissingDatesRequestFailed);
            return;
        }

        if (response?.result != true)
        {
            var message = response?.message ?? LogMessages.PlcDataSendService.UnknownError;
            _logger.LogWarning(LogMessages.MissingDataResendService.MissingDatesResponseInvalid, message);
            return;
        }

        var missingDates = response.objects?.MissingDates ?? new List<DateTime>();
        if (missingDates.Count == 0)
            return;

        foreach (var missingDate in missingDates.OrderBy(date => date))
        {
            if (cancellationToken.IsCancellationRequested)
                break;

            var record = await _sendDataService.GetByReadTimeAsync(station.StationId, missingDate);
            if (record is null)
            {
                _logger.LogInformation(LogMessages.MissingDataResendService.DataNotFound, missingDate);
                continue;
            }

            await ResendAsync(record);
        }
    }

    private async Task ResendAsync(SendDataRecord record)
    {
        ApiSendDataDto payload = CreatePayload(record);
        ResultStatus<SendDataResult>? sendResponse;
        try
        {
            sendResponse = await _saisApiService.SendDataAsync(payload);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, LogMessages.MissingDataResendService.SendDataRequestFailed, record.Readtime);
            return;
        }

        var invalidCodes = SendDataResultEvaluator.ExtractInvalidStatusCodes(sendResponse?.objects);
        if (invalidCodes.Count > 0)
        {
            var codes = string.Join(", ", invalidCodes.Select(code => ((int)code).ToString()));
            _logger.LogWarning(LogMessages.MissingDataResendService.InvalidStatusCodesReceived, record.Readtime, codes);
        }

        var success = sendResponse?.result == true;
        if (!success)
        {
            var message = sendResponse?.message ?? LogMessages.PlcDataSendService.UnknownError;
            _logger.LogWarning(LogMessages.MissingDataResendService.SendDataFailed, record.Readtime, message);
        }

        var flags = SendDataResultEvaluator.MapInvalidStatusFlags(invalidCodes);
        var updateRequest = new SendDataStatusUpdateRequest
        {
            Id = record.Id,
            IsSent = success,
            SaatlikYikamaGecersiz = flags.SaatlikYikamaGecersiz,
            HaftalikYikamaGecersiz = flags.HaftalikYikamaGecersiz,
            KalibrasyonGecersiz = flags.KalibrasyonGecersiz,
            AkisHiziGecersiz = flags.AkisHiziGecersiz,
            GecersizDebi = flags.GecersizDebi,
            TekrarVeriGecersiz = flags.TekrarVeriGecersiz,
            GecersizOlcumBirimi = flags.GecersizOlcumBirimi
        };

        var updated = await _sendDataService.UpdateStatusAsync(updateRequest);
        if (!updated)
        {
            _logger.LogWarning(LogMessages.MissingDataResendService.UpdateStatusFailed, record.Id);
        }
    }

    private static ApiSendDataDto CreatePayload(SendDataRecord record)
    {
        return new ApiSendDataDto
        {
            Id = record.Id,
            Stationid = record.Stationid,
            Readtime = record.Readtime,
            SoftwareVersion = record.SoftwareVersion,
            AkisHizi = record.AkisHizi,
            AKM = record.AKM,
            CozunmusOksijen = record.CozunmusOksijen,
            Debi = record.Debi,
            DesarjDebi = record.DesarjDebi,
            HariciDebi = record.HariciDebi,
            HariciDebi2 = record.HariciDebi2,
            KOi = record.KOi,
            pH = record.pH,
            Sicaklik = record.Sicaklik,
            Iletkenlik = record.Iletkenlik,
            Period = record.Period,
            AkisHizi_Status = record.AkisHizi_Status,
            AKM_Status = record.AKM_Status,
            CozunmusOksijen_Status = record.CozunmusOksijen_Status,
            Debi_Status = record.Debi_Status,
            DesarjDebi_Status = record.DesarjDebi_Status,
            HariciDebi_Status = record.HariciDebi_Status,
            HariciDebi2_Status = record.HariciDebi2_Status,
            KOi_Status = record.KOi_Status,
            pH_Status = record.pH_Status,
            Sicaklik_Status = record.Sicaklik_Status,
            Iletkenlik_Status = record.Iletkenlik_Status
        };
    }
}
