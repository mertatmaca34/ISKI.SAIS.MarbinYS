using System.Net.Http.Json;
using WinUI.Constants;
using WinUI.Models;

namespace WinUI.Services;

public interface ILogService
{
    Task<List<LogDto>?> GetAsync(DateTime startDate, DateTime endDate, bool descending);
}

public class LogService(HttpClient httpClient) : ILogService
{
    public async Task<List<LogDto>?> GetAsync(DateTime startDate, DateTime endDate, bool descending)
    {
        string url = $"{LogsConstants.ApiUrl}?startDate={startDate:o}&endDate={endDate:o}&descending={descending}";
        return await httpClient.GetFromJsonAsync<List<LogDto>>(url);
    }
}
