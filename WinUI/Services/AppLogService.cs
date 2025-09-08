using System.Net.Http.Json;
using WinUI.Models;

namespace WinUI.Services;

public interface IAppLogService
{
    Task<List<AppLogDto>?> GetLogsAsync(DateTime start, DateTime end, bool descending);
}

public class AppLogService(HttpClient httpClient) : IAppLogService
{
    public async Task<List<AppLogDto>?> GetLogsAsync(DateTime start, DateTime end, bool descending)
    {
        string orderParam = descending ? "true" : "false";
        string url = $"api/applogs?startDate={start:o}&endDate={end:o}&descending={orderParam}";
        return await httpClient.GetFromJsonAsync<List<AppLogDto>>(url);
    }
}
