using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Domain.Entities;
using Domain.Enums;
using WinUI.Constants;
using WinUI.Models;

namespace WinUI.Services;

public class PlcDataSendService : BackgroundService
{
    private readonly IPlcDataService _plcService;
    private readonly IApiEndpointService _apiEndpointService;
    private readonly IStationService _stationService;
    private readonly ISaisApiService _saisApiService;
    private readonly ISendDataService _sendDataService;
    private readonly ILogger<PlcDataSendService> _logger;

    public PlcDataSendService(
        IPlcDataService plcService,
        IApiEndpointService apiEndpointService,
        IStationService stationService,
        ISaisApiService saisApiService,
        ISendDataService sendDataService,
        ILogger<PlcDataSendService> logger)
    {
        _plcService = plcService;
        _apiEndpointService = apiEndpointService;
        _stationService = stationService;
        _saisApiService = saisApiService;
        _sendDataService = sendDataService;
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            var delay = TimeSpan.FromMinutes(1);

            try
            {
                var endpoint = await _apiEndpointService.GetFirstAsync();
                delay = ResolveDelay(endpoint);

                if (endpoint == null)
                {
                    _logger.LogWarning(LogMessages.SaisApiNotConfigured);
                }
                else
                {
                    await ProcessAndPersistAsync();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, LogMessages.PlcDataSendService.UnexpectedError);
            }

            try
            {
                await Task.Delay(delay, stoppingToken);
            }
            catch (TaskCanceledException)
            {
                // ignore cancellation
            }
        }
    }

    private async Task ProcessAndPersistAsync()
    {
        var station = await _stationService.GetFirstAsync();
        if (station == null)
        {
            _logger.LogWarning(LogMessages.PlcDataSendService.StationInfoNotFound);
            return;
        }

        PlcDataDto plcData;
        try
        {
            plcData = await _plcService.GetLatestAsync();
        }
        catch (InvalidOperationException ex) when (string.Equals(ex.Message, "PLC_NOT_CONFIGURED", StringComparison.OrdinalIgnoreCase))
        {
            _logger.LogWarning(LogMessages.PlcDataSendService.PlcInfoNotFound);
            return;
        }

        if (plcData == null)
        {
            _logger.LogWarning(LogMessages.PlcDataSendService.PlcDataUnavailable);
            return;
        }

        var readTime = DateTime.Now;
        var status = ResolveStatus(plcData.Digital);
        var statusCode = (int)status;
        var statusString = statusCode.ToString();

        var payload = CreateApiSendDataDto(station, plcData.Analog, readTime, statusCode);
        var sendData = CreateSendData(station, plcData.Analog, status, statusString, readTime);

        var isSent = await TrySendToSaisAsync(payload);
        sendData.IsSent = isSent;

        await _sendDataService.CreateAsync(sendData);
    }

    private async Task<bool> TrySendToSaisAsync(ApiSendDataDto body)
    {
        try
        {
            var result = await _saisApiService.SendDataAsync(body);
            if (result?.result == true)
            {
                return true;
            }

            _logger.LogWarning(LogMessages.PlcDataSendService.SendDataFailed, result?.message ?? LogMessages.PlcDataSendService.UnknownError);
            return false;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, LogMessages.PlcDataSendService.SendDataRequestFailed);
            return false;
        }
    }

    private static ApiSendDataDto CreateApiSendDataDto(StationDto station, AnalogSensorDataDto analog, DateTime readTime, int statusCode)
    {
        var statusString = statusCode.ToString();
        return new ApiSendDataDto
        {
            Readtime = readTime,
            Stationid = station.StationId,
            SoftwareVersion = "1.0.0",
            AkisHizi = analog.AkisHizi,
            AKM = analog.Akm,
            CozunmusOksijen = analog.CozunmusOksijen,
            Debi = analog.Debi,
            DesarjDebi = null,
            HariciDebi = null,
            HariciDebi2 = null,
            KOi = analog.Koi,
            pH = analog.Ph,
            Sicaklik = analog.Sicaklik,
            Iletkenlik = analog.Iletkenlik,
            Period = 1,
            AkisHizi_Status = statusCode,
            AKM_Status = statusCode,
            CozunmusOksijen_Status = statusCode,
            Debi_Status = statusCode,
            DesarjDebi_Status = null,
            HariciDebi_Status = null,
            HariciDebi2_Status = null,
            KOi_Status = statusCode,
            pH_Status = statusCode,
            Sicaklik_Status = statusCode,
            Iletkenlik_Status = statusString
        };
    }

    private static SendData CreateSendData(StationDto station, AnalogSensorDataDto analog, SensorStatusCode status, string statusString, DateTime readTime)
    {
        var statusCode = (int)status;
        return new SendData
        {
            Stationid = station.StationId,
            Readtime = readTime,
            SoftwareVersion = station.Software,
            AkisHizi = analog.AkisHizi,
            AKM = analog.Akm,
            CozunmusOksijen = analog.CozunmusOksijen,
            Debi = analog.Debi,
            DesarjDebi = analog.DesarjDebi,
            HariciDebi = analog.HariciDebi,
            HariciDebi2 = analog.HariciDebi2,
            KOi = analog.Koi,
            pH = analog.Ph,
            Sicaklik = analog.Sicaklik,
            Iletkenlik = analog.Iletkenlik,
            Period = 1,
            AkisHizi_Status = statusCode,
            AKM_Status = statusCode,
            CozunmusOksijen_Status = statusCode,
            Debi_Status = statusCode,
            DesarjDebi_Status = statusCode,
            HariciDebi_Status = statusCode,
            HariciDebi2_Status = statusCode,
            KOi_Status = statusCode,
            pH_Status = statusCode,
            Sicaklik_Status = statusCode,
            Iletkenlik_Status = statusString
        };
    }

    private static TimeSpan ResolveDelay(ApiEndpointDto? endpoint)
    {
        var period = endpoint?.DataSendPeriodMinute;
        if (!period.HasValue || period.Value <= 0)
        {
            return TimeSpan.FromMinutes(1);
        }

        return TimeSpan.FromMinutes(period.Value);
    }

    private static SensorStatusCode ResolveStatus(WinUI.Models.DigitalSensorDataDto digital)
    {
        if (digital.KabinBakim)
            return SensorStatusCode.IstasyonBakimda;
        if (digital.KabinKalibrasyon)
            return SensorStatusCode.SistemKal;
        if (digital.KabinHaftalikYikamada)
            return SensorStatusCode.HaftalikYikama;
        if (digital.KabinSaatlikYikamada)
            return SensorStatusCode.Yikama;
        if (digital.KabinDuman || digital.KabinSuBaskini || digital.KabinKapiAcildi || digital.KabinEnerjiYok || digital.KabinAcilStopBasili)
            return SensorStatusCode.Alarm;
        if (digital.KabinOto)
            return SensorStatusCode.VeriGecerli;

        return SensorStatusCode.VeriYok;
    }
}
