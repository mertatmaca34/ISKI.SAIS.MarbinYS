using System.Net.Http.Json;
using WinUI.Constants;
using WinUI.Models;

namespace WinUI.Services;

public record CreateCalibrationMeasurementCommand(
    DateTime TimeStamp,
    string Parameter,
    double ZeroRef,
    double ZeroMeas,
    double ZeroDiff,
    double ZeroStd,
    double SpanRef,
    double SpanMeas,
    double SpanDiff,
    double SpanStd,
    double ResultFactor,
    bool IsItValid);

public interface ICalibrationMeasurementService
{
    Task<CalibrationMeasurementDto?> CreateAsync(CreateCalibrationMeasurementCommand command);
}

public class CalibrationMeasurementService(HttpClient httpClient) : ICalibrationMeasurementService
{
    public async Task<CalibrationMeasurementDto?> CreateAsync(CreateCalibrationMeasurementCommand command)
    {
        using var response = await httpClient.PostAsJsonAsync(CalibrationMeasurementConstants.ApiUrl, command);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<CalibrationMeasurementDto>();
    }
}
