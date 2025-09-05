using System;
using System.Net.Http.Json;
using WinUI.Constants;
using WinUI.Models;

namespace WinUI.Services;

public interface IStationInformationService
{
    Task<StationDto?> GetAsync(Guid stationId);
}

public class StationInformationService(HttpClient httpClient) : IStationInformationService
{
    private record StationInfoResponse(StationDto? Data);

    public async Task<StationDto?> GetAsync(Guid stationId)
    {
        var request = new { stationId };
        using var response = await httpClient.PostAsJsonAsync(StationConstants.StationInfoApiUrl, request);
        response.EnsureSuccessStatusCode();
        var result = await response.Content.ReadFromJsonAsync<StationInfoResponse>();
        return result?.Data;
    }
}
