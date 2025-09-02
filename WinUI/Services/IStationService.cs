using WinUI.Models;

namespace WinUI.Services;

public interface IStationService
{
    Task<StationDto?> CreateAsync(CreateStationCommand command);
}

