using System;
using System.Net.Http.Json;
using WinUI.Models;

namespace WinUI.Services;

public interface ILogService
{
    Task<List<LogDto>?> GetLogsAsync(DateTime start, DateTime end, bool descending);
}

public class LogService(HttpClient httpClient) : ILogService
{
    public async Task<List<LogDto>?> GetLogsAsync(DateTime start, DateTime end, bool descending)
    {
        string orderParam = descending ? "true" : "false";
        string startParam = Uri.EscapeDataString(start.ToString("o"));
        string endParam = Uri.EscapeDataString(end.ToString("o"));
        string url = $"api/logs?startDate={startParam}&endDate={endParam}&descending={orderParam}";
        return await httpClient.GetFromJsonAsync<List<LogDto>>(url);
    }
}
