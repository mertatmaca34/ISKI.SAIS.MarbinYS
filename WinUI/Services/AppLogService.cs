using System;
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
        string startParam = Uri.EscapeDataString(start.ToString("o"));
        string endParam = Uri.EscapeDataString(end.ToString("o"));
        string url = $"api/applogs?startDate={startParam}&endDate={endParam}&descending={orderParam}";
        return await httpClient.GetFromJsonAsync<List<AppLogDto>>(url);
    }
}
