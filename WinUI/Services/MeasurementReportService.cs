using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WinUI.Models;

namespace WinUI.Services;

public interface IMeasurementReportService
{
    Task<List<ApiDataResultDto>> GetMeasurementsAsync(DateTime startDate, DateTime endDate);
}

public class MeasurementReportService : IMeasurementReportService
{
    private readonly ISaisApiService _saisApiService;
    private readonly IStationService _stationService;

    public MeasurementReportService(ISaisApiService saisApiService, IStationService stationService)
    {
        _saisApiService = saisApiService;
        _stationService = stationService;
    }

    public async Task<List<ApiDataResultDto>> GetMeasurementsAsync(DateTime startDate, DateTime endDate)
    {
        var station = await _stationService.GetFirstAsync();
        if (station == null || station.DataPeriodMinute == null)
            return new List<ApiDataResultDto>();

        var result = await _saisApiService.GetDataByBetweenTwoDateAsync(
            station.StationId,
            station.DataPeriodMinute.Value,
            startDate,
            endDate);
        return result?.Objects ?? new List<ApiDataResultDto>();
    }
}

