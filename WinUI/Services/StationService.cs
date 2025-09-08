using System;
using System.Net.Http.Json;
using System.Linq;
using WinUI.Constants;
using WinUI.Models;

namespace WinUI.Services;

public record CreateStationCommand(
    Guid StationId,
    string Code,
    string Name,
    short? DataPeriodMinute,
    DateTime? LastDataDate,
    string ConnectionDomainAddress,
    int? ConnectionPort,
    string ConnectionUser,
    string ConnectionPassword,
    string Company,
    DateTime? BirtDate,
    DateTime? SetupDate,
    string Address,
    string Software);

public record UpdateStationCommand(
    Guid StationId,
    string Code,
    string Name,
    short? DataPeriodMinute,
    DateTime? LastDataDate,
    string ConnectionDomainAddress,
    int? ConnectionPort,
    string ConnectionUser,
    string ConnectionPassword,
    string Company,
    DateTime? BirtDate,
    DateTime? SetupDate,
    string Address,
    string Software);

public interface IStationService
{
    Task<StationDto?> GetFirstAsync();
    Task<StationDto?> CreateAsync(CreateStationCommand command);
    Task<StationDto?> UpdateAsync(UpdateStationCommand command);
}

public class StationService(HttpClient httpClient) : IStationService
{
    public async Task<StationDto?> GetFirstAsync()
    {
        var list = await httpClient.GetFromJsonAsync<List<StationDto>>(StationConstants.ApiUrl);
        return list?.FirstOrDefault();
    }

    public async Task<StationDto?> CreateAsync(CreateStationCommand command)
    {
        using var response = await httpClient.PostAsJsonAsync(StationConstants.ApiUrl, command);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<StationDto>();
    }

    public async Task<StationDto?> UpdateAsync(UpdateStationCommand command)
    {
        using var response = await httpClient.PutAsJsonAsync($"{StationConstants.ApiUrl}/{command.StationId}", command);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<StationDto>();
    }
}
