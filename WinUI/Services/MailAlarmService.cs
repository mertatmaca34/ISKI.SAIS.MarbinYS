using System.Net.Http.Json;
using Domain.Enums;
using WinUI.Constants;
using WinUI.Models;

namespace WinUI.Services;

public interface IMailAlarmService
{
    Task<List<MailAlarmDto>?> GetListAsync(int userId);
    Task UpdateAsync(int userId, List<int> alarmIds);
    Task<MailAlarmDto?> UpdateAlarmAsync(UpdateMailAlarmCommand command);
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

    public async Task<MailAlarmDto?> UpdateAlarmAsync(UpdateMailAlarmCommand command)
    {
        using var response = await httpClient.PutAsJsonAsync($"{MailAlarmConstants.ApiUrl}/{command.Id}", command);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<MailAlarmDto>();
    }
}

public record UpdateMailAlarmCommand(
    int Id,
    string Name,
    string Channel,
    double Limit,
    string MailSubject,
    string MailBody,
    MailTemplateType TemplateType);

