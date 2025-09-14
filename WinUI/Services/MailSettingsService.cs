using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WinUI.Constants;
using WinUI.Models;

namespace WinUI.Services;

public record CreateMailSettingsCommand(
    string SmtpHost,
    int SmtpPort,
    string SmtpUser,
    string SmtpPassword,
    bool UseSsl,
    string SenderEmail,
    string SenderName,
    bool UseDefaultCredentials);

public record UpdateMailSettingsCommand(
    int Id,
    string SmtpHost,
    int SmtpPort,
    string SmtpUser,
    string SmtpPassword,
    bool UseSsl,
    string SenderEmail,
    string SenderName,
    bool UseDefaultCredentials);

public interface IMailSettingsService
{
    Task<MailSettingsDto?> GetFirstAsync();
    Task<MailSettingsDto?> CreateAsync(CreateMailSettingsCommand command);
    Task<MailSettingsDto?> UpdateAsync(UpdateMailSettingsCommand command);
}

public class MailSettingsService(HttpClient httpClient) : IMailSettingsService
{
    public async Task<MailSettingsDto?> GetFirstAsync()
    {
        var list = await httpClient.GetFromJsonAsync<List<MailSettingsDto>>(MailSettingsConstants.ApiUrl);
        return list?.FirstOrDefault();
    }

    public async Task<MailSettingsDto?> CreateAsync(CreateMailSettingsCommand command)
    {
        using var response = await httpClient.PostAsJsonAsync(MailSettingsConstants.ApiUrl, command);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<MailSettingsDto>();
    }

    public async Task<MailSettingsDto?> UpdateAsync(UpdateMailSettingsCommand command)
    {
        using var response = await httpClient.PutAsJsonAsync($"{MailSettingsConstants.ApiUrl}/{command.Id}", command);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<MailSettingsDto>();
    }
}

