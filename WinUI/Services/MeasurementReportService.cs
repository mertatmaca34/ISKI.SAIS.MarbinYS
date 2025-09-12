using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WinUI.Constants;
using WinUI.Models;

namespace WinUI.Services;

public interface IMeasurementReportService
{
    Task<List<ApiDataResultDto>> GetMeasurementsAsync(DateTime startDate, DateTime endDate);
}

public class MeasurementReportService(HttpClient httpClient) : IMeasurementReportService
{
    public async Task<List<ApiDataResultDto>> GetMeasurementsAsync(DateTime startDate, DateTime endDate)
    {
        var items = await httpClient.GetFromJsonAsync<List<ApiDataResultDto>>(SendDataConstants.ApiUrl);
        if (items == null)
            return new List<ApiDataResultDto>();

        return items
            .Where(x => x.ReadTime >= startDate && x.ReadTime < endDate)
            .ToList();
    }
}
