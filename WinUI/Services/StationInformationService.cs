using System;
using WinUI.Models;

namespace WinUI.Services;

public interface IStationInformationService
{
    Task<StationDto?> GetAsync(Guid stationId);
}

public class StationInformationService(ISaisApiService saisApiService) : IStationInformationService
{
    private readonly ISaisApiService _saisApiService = saisApiService;

    public async Task<StationDto?> GetAsync(Guid stationId)
    {
        var result = await _saisApiService.GetStationInformationAsync(stationId);
        return result?.objects;
    }
}

