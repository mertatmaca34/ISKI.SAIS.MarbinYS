using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Domain.Entities;
using Domain.Enums;
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
                var station = await _stationService.GetFirstAsync();
                if (endpoint != null)
                {
                    delay = TimeSpan.FromMinutes(endpoint.DataSendPeriodMinute ?? 1);
                }

                if (endpoint == null)
                {
                    _logger.LogWarning("Api bilgileri henüz kurulmadı.");
                }
                else if (station != null)
                {
                    try
                    {
                        var plcData = await _plcService.GetLatestAsync();
                        if (plcData != null)
                        {
                            var readTime = DateTime.Now;

                            var status = ResolveStatus(plcData.Digital);
                            var statusString = ((int)status).ToString();

                            var body = new ApiSendDataDto
                            {
                                StationId = station.StationId,
                                StartTime = readTime,
                                SoftwareVersion = station.Software,
                                Regions = string.Empty,
                                StationStatus = statusString,
                                AAKM = plcData.Analog.Akm,
                                BGM = plcData.Analog.AkisHizi,
                                AAKM_Status = statusString,
                                BGM_Status = statusString,
                                CozunmusOksijen = plcData.Analog.CozunmusOksijen,
                                COJ_Status = statusString,
                                Koi = plcData.Analog.Koi,
                                Koi_Status = statusString,
                                Debi = plcData.Analog.Debi,
                                Debi_Status = statusString,
                                Sicaklik = plcData.Analog.Sicaklik
                            };

                            var result = await _saisApiService.SendDataAsync(body);
                            bool isSent = result?.result ?? false;
                            if (!isSent)
                            {
                                _logger.LogWarning("SAIS SendData failed: {Message}", result?.message ?? "Unknown error");
                            }

                            var sendData = new SendData
                            {
                                Stationid = station.StationId,
                                Readtime = readTime,
                                SoftwareVersion = station.Software,
                                AkisHizi = plcData.Analog.AkisHizi,
                                AKM = plcData.Analog.Akm,
                                CozunmusOksijen = plcData.Analog.CozunmusOksijen,
                                Debi = plcData.Analog.Debi,
                                DesarjDebi = plcData.Analog.DesarjDebi,
                                HariciDebi = plcData.Analog.HariciDebi,
                                HariciDebi2 = plcData.Analog.HariciDebi2,
                                KOi = plcData.Analog.Koi,
                                pH = plcData.Analog.Ph,
                                Sicaklik = plcData.Analog.Sicaklik,
                                Iletkenlik = plcData.Analog.Iletkenlik,
                                Period = 1,
                                AkisHizi_Status = (int)status,
                                AKM_Status = (int)status,
                                CozunmusOksijen_Status = (int)status,
                                Debi_Status = (int)status,
                                DesarjDebi_Status = (int)status,
                                HariciDebi_Status = (int)status,
                                HariciDebi2_Status = (int)status,
                                KOi_Status = (int)status,
                                pH_Status = (int)status,
                                Sicaklik_Status = (int)status,
                                Iletkenlik_Status = statusString,
                                IsSent = isSent
                            };

                            await _sendDataService.CreateAsync(sendData);
                        }
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "Veri gönderilemedi");
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ayarlar okunurken hata oluştu");
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
