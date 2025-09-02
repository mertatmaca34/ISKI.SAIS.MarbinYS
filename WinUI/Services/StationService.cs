using System.Net.Http;
using System.Net.Http.Json;
using WinUI.Models;

namespace WinUI.Services;

public class StationService : IStationService
{
    private readonly HttpClient _httpClient;

    public StationService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<StationDto?> CreateAsync(CreateStationCommand command)
    {
        using var response = await _httpClient.PostAsJsonAsync("api/stations", command);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<StationDto>();
    }
}

