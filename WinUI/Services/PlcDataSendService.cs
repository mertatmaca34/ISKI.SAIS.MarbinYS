using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using WinUI.Constants;
using WinUI.Models;

namespace WinUI.Services;

public class PlcDataSendService : BackgroundService
{
    private readonly IPlcDataService _plcService;
    private readonly IApiEndpointService _apiEndpointService;
    private readonly ITicketService _ticketService;
    private readonly IStationService _stationService;
    private readonly HttpClient _httpClient;

    public PlcDataSendService(
        IPlcDataService plcService,
        IApiEndpointService apiEndpointService,
        ITicketService ticketService,
        IStationService stationService)
    {
        _plcService = plcService;
        _apiEndpointService = apiEndpointService;
        _ticketService = ticketService;
        _stationService = stationService;
        var handler = new HttpClientHandler();
        handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
        _httpClient = new HttpClient(handler);
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

                if (endpoint != null && station != null)
                {
                    try
                    {
                        await _ticketService.EnsureTicketAsync();
                        var plcData = await _plcService.GetLatestAsync();
                        if (plcData != null)
                        {
                            var body = new ApiSendDataDto
                            {
                                StationId = station.StationId,
                                StartTime = DateTime.Now,
                                SoftwareVersion = station.Software,
                                Regions = string.Empty,
                                StationStatus = string.Empty,
                                AAKM = plcData.Analog.Akm,
                                BGM = plcData.Analog.AkisHizi,
                                CozunmusOksijen = plcData.Analog.CozunmusOksijen,
                                Koi = plcData.Analog.Koi,
                                Debi = plcData.Analog.Debi,
                                Sicaklik = plcData.Analog.Sicaklik
                            };

                            _httpClient.DefaultRequestHeaders.Remove("AToken");
                            _httpClient.DefaultRequestHeaders.Add("AToken", JsonSerializer.Serialize(new AToken { TicketId = StationConstants.Ticket }));

                            var url = $"{endpoint.ApiAddress.TrimEnd('/')}/SAIS/SendData";
                            using var response = await _httpClient.PostAsJsonAsync(url, body, stoppingToken);
                            // ignore non-success for now
                        }
                    }
                    catch
                    {
                        // ignore send errors
                    }
                }
            }
            catch
            {
                // ignore configuration errors
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
}
