using WinUI.Models;

namespace WinUI.Services;

public interface IPlcDataService
{
    Task<PlcDataDto?> ReadAndSaveAsync();
}
