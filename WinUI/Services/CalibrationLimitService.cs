using System.Net.Http.Json;
using WinUI.Constants;
using WinUI.Models;

namespace WinUI.Services;

public record CreateCalibrationLimitCommand(
    string Parameter,
    int ZeroRef,
    int ZeroTimeStamp,
    int SpanRef,
    int SpanTimeStamp);

public record UpdateCalibrationLimitCommand(
    int Id,
    string Parameter,
    int ZeroRef,
    int ZeroTimeStamp,
    int SpanRef,
    int SpanTimeStamp);

public interface ICalibrationLimitService
{
    Task<List<CalibrationLimitDto>?> GetListAsync();
    Task<CalibrationLimitDto?> CreateAsync(CreateCalibrationLimitCommand command);
    Task<CalibrationLimitDto?> UpdateAsync(UpdateCalibrationLimitCommand command);
}

public class CalibrationLimitService(HttpClient httpClient) : ICalibrationLimitService
{
    public async Task<List<CalibrationLimitDto>?> GetListAsync()
    {
        return await httpClient.GetFromJsonAsync<List<CalibrationLimitDto>>(CalibrationLimitConstants.ApiUrl);
    }

    public async Task<CalibrationLimitDto?> CreateAsync(CreateCalibrationLimitCommand command)
    {
        using var response = await httpClient.PostAsJsonAsync(CalibrationLimitConstants.ApiUrl, command);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<CalibrationLimitDto>();
    }

    public async Task<CalibrationLimitDto?> UpdateAsync(UpdateCalibrationLimitCommand command)
    {
        using var response = await httpClient.PutAsJsonAsync($"{CalibrationLimitConstants.ApiUrl}/{command.Id}", command);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<CalibrationLimitDto>();
    }
}
