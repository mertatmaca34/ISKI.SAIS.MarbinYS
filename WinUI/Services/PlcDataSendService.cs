using System;
using System.Collections.Generic;
using System.IO;
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
    private readonly string _pendingFilePath = Path.Combine(AppContext.BaseDirectory, "unsent-data.json");

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
                    ApiSendDataDto? body = null;
                    try
                    {
                        await _ticketService.EnsureTicketAsync();
                        await SendPendingDataAsync(endpoint, stoppingToken);
                        var plcData = await _plcService.ReadAndSaveAsync();
                        if (plcData != null)
                        {
                            body = new ApiSendDataDto
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
                            if (!response.IsSuccessStatusCode)
                            {
                                await AddPendingAsync(body);
                            }
                        }
                    }
                    catch
                    {
                        if (body != null)
                            await AddPendingAsync(body);
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

    private async Task<List<ApiSendDataDto>> LoadPendingAsync()
    {
        if (!File.Exists(_pendingFilePath))
            return new List<ApiSendDataDto>();
        await using var stream = File.OpenRead(_pendingFilePath);
        return await JsonSerializer.DeserializeAsync<List<ApiSendDataDto>>(stream) ?? new List<ApiSendDataDto>();
    }

    private async Task SavePendingAsync(List<ApiSendDataDto> items)
    {
        await using var stream = File.Create(_pendingFilePath);
        await JsonSerializer.SerializeAsync(stream, items);
    }

    private async Task AddPendingAsync(ApiSendDataDto dto)
    {
        var items = await LoadPendingAsync();
        items.Add(dto);
        await SavePendingAsync(items);
    }

    private async Task SendPendingDataAsync(ApiEndpointDto endpoint, CancellationToken token)
    {
        var items = await LoadPendingAsync();
        if (items.Count == 0) return;

        var remaining = new List<ApiSendDataDto>();
        foreach (var item in items)
        {
            if (DateTime.Now - item.StartTime > TimeSpan.FromHours(48))
                continue;
            try
            {
                _httpClient.DefaultRequestHeaders.Remove("AToken");
                _httpClient.DefaultRequestHeaders.Add("AToken", JsonSerializer.Serialize(new AToken { TicketId = StationConstants.Ticket }));
                var url = $"{endpoint.ApiAddress.TrimEnd('/')}/SAIS/SendData";
                using var response = await _httpClient.PostAsJsonAsync(url, item, token);
                if (!response.IsSuccessStatusCode)
                {
                    remaining.Add(item);
                }
            }
            catch
            {
                remaining.Add(item);
            }
        }
        await SavePendingAsync(remaining);
    }
}
