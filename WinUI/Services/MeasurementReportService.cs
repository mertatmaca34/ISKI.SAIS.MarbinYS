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
    Task<List<ApiDataResultDto>> GetMeasurementsAsync(DateTime startDate, DateTime endDate, bool descending);
}

public class MeasurementReportService(HttpClient httpClient) : IMeasurementReportService
{
    public async Task<List<ApiDataResultDto>> GetMeasurementsAsync(DateTime startDate, DateTime endDate, bool descending)
    {
        var items = await httpClient.GetFromJsonAsync<List<ApiDataResultDto>>(SendDataConstants.ApiUrl);
        if (items == null)
            return new List<ApiDataResultDto>();

        var filtered = items.Where(x => x.ReadTime >= startDate && x.ReadTime < endDate);

        return descending
            ? filtered.OrderByDescending(x => x.ReadTime).ToList()
            : filtered.OrderBy(x => x.ReadTime).ToList();
    }
}
