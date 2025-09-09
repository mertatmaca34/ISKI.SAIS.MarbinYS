using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using Microsoft.AspNetCore.WebUtilities;
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
        var query = new Dictionary<string, string?>
        {
            ["startDate"] = start.ToString("o"),
            ["endDate"] = end.ToString("o"),
            ["descending"] = descending.ToString().ToLower()
        };
        string url = QueryHelpers.AddQueryString("api/logs", query);
        return await httpClient.GetFromJsonAsync<List<LogDto>>(url);
    }
}
