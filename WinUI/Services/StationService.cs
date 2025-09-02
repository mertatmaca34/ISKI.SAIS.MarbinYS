using System.Net.Http.Json;
using WinUI.Constants;
using WinUI.Models;

namespace WinUI.Services;

public record CreateStationCommand(
    Guid StationId,
    string Code,
    string Name,
    int DataPeriodMinute,
    DateTime LastDataDate,
    string ConnectionDomainAddress,
    string ConnectionPort,
    string ConnectionUser,
    string ConnectionPassword,
    string Company,
    DateTime BirtDate,
    DateTime SetupDate,
    string Address,
    string Software);

public interface IStationService
{
    Task<StationDto?> CreateAsync(CreateStationCommand command);
}

public class StationService(HttpClient httpClient) : IStationService
{
    public async Task<StationDto?> CreateAsync(CreateStationCommand command)
    {
        using var response = await httpClient.PostAsJsonAsync(StationConstants.ApiUrl, command);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<StationDto>();
    }
}
