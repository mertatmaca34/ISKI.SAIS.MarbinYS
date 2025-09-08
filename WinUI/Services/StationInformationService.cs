using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using WinUI.Constants;
using WinUI.Models;

namespace WinUI.Services;

public interface IStationInformationService
{
    Task<StationDto?> GetAsync(Guid stationId);
}

public class StationInformationService(HttpClient httpClient, ITicketService ticketService) : IStationInformationService
{
    private readonly HttpClient _httpClient = httpClient;
    private readonly ITicketService _ticketService = ticketService;

    public async Task<StationDto?> GetAsync(Guid stationId)
    {
        await _ticketService.EnsureTicketAsync();

        var url = $"{StationConstants.StationInfoApiUrl}?stationId={stationId}";
        using var request = new HttpRequestMessage(HttpMethod.Post, url);

        _httpClient.DefaultRequestHeaders.Remove("AToken");
        _httpClient.DefaultRequestHeaders.Add("AToken", JsonSerializer.Serialize(new AToken { TicketId = StationConstants.Ticket }));

        using var response = await _httpClient.SendAsync(request);
        response.EnsureSuccessStatusCode();
        var result = await response.Content.ReadFromJsonAsync<ResultStatus<StationDto>>();
        return result?.objects;
    }
}

