using System;
using System.Linq.Dynamic.Core.Tokenizer;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
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

    private record StationInfoResponse(StationDto? Data);

    public async Task<StationDto?> GetAsync(Guid stationId)
    {
        await _ticketService.EnsureTicketAsync();

        using var request = new HttpRequestMessage(HttpMethod.Post, StationConstants.StationInfoApiUrl);

        _httpClient.DefaultRequestHeaders.Add("AToken", JsonSerializer.Serialize(new AToken { TicketId = StationConstants.Ticket }));

        var body = new { stationId, ticket = StationConstants.Ticket };
        request.Content = JsonContent.Create(body);

        using var response = await _httpClient.SendAsync(request);
        response.EnsureSuccessStatusCode();
        var result = await response.Content.ReadFromJsonAsync<StationInfoResponse>();
        return result?.Data;
    }
}
