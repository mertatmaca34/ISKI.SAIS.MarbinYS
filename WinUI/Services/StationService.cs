using System.Net.Http.Json;
using WinUI.Models;

namespace WinUI.Services;

public record CreateStationCommand(string StationName, Guid StationId);

public interface IStationService
{
    Task<StationDto?> CreateAsync(CreateStationCommand command);
}

public class StationService(HttpClient httpClient) : IStationService
{
    public async Task<StationDto?> CreateAsync(CreateStationCommand command)
    {
        using var response = await httpClient.PostAsJsonAsync("api/stations", command);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<StationDto>();
    }
}