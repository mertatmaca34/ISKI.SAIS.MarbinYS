using System.Net.Http.Json;
using WinUI.Constants;
using WinUI.Models;

namespace WinUI.Services;

public interface IMailAlarmService
{
    Task<List<MailAlarmDto>?> GetListAsync(int userId);
    Task UpdateAsync(int userId, List<int> alarmIds);
}

public class MailAlarmService(HttpClient httpClient) : IMailAlarmService
{
    public async Task<List<MailAlarmDto>?> GetListAsync(int userId)
        => await httpClient.GetFromJsonAsync<List<MailAlarmDto>>($"{MailAlarmConstants.ApiUrl}/{userId}");

    public async Task UpdateAsync(int userId, List<int> alarmIds)
    {
        using var response = await httpClient.PostAsJsonAsync($"{MailAlarmConstants.ApiUrl}/{userId}", alarmIds);
        response.EnsureSuccessStatusCode();
    }
}

