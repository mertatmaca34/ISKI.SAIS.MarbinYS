using System.Net.Http.Json;
using WinUI.Constants;
using WinUI.Models;

using System;

namespace WinUI.Services;

public interface ILogService
{
    Task<List<LogDto>?> GetAsync(DateTime startDate, DateTime endDate, bool descending);
}

public class LogService(HttpClient httpClient) : ILogService
{
    public async Task<List<LogDto>?> GetAsync(DateTime startDate, DateTime endDate, bool descending)
    {
        string url = $"{LogsConstants.ApiUrl}?startDate={Uri.EscapeDataString(startDate.ToString("O"))}&endDate={Uri.EscapeDataString(endDate.ToString("O"))}&descending={descending}";
        var response = await httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<List<LogDto>>();
    }
}
