using Microsoft.Extensions.Logging;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using WinUI.Constants;
using WinUI.Models;

namespace WinUI.Services;

public interface ITicketService
{
    Task EnsureTicketAsync();
    Task<ResultStatus<LoginResult>?> RefreshTicketAsync(CancellationToken ct = default);
}

public class TicketService(HttpClient httpClient, IApiEndpointService apiEndpointService, ILogger<TicketService> logger) : ITicketService
{
    private static readonly JsonSerializerOptions JsonOpts = new();
    public async Task EnsureTicketAsync()
    {
        if (!string.IsNullOrEmpty(StationConstants.Ticket) && DateTime.Now < StationConstants.TicketExpiry)
        {
            return;
        }

        logger.LogWarning(LogMessages.TicketService.TicketMissingOrExpired);
        await RefreshTicketAsync();
    }

    public async Task<ResultStatus<LoginResult>?> RefreshTicketAsync(CancellationToken ct = default)
    {
        var endpoint = await apiEndpointService.GetFirstAsync();
        if (endpoint == null)
        {
            logger.LogWarning(LogMessages.SaisApiNotConfigured);
            return null;
        }

        var loginUrl = $"{endpoint.ApiAddress?.TrimEnd('/')}/security/login";
        var loginRequest = new
        {
            username = endpoint.UserName,
            password = MD5Hash(MD5Hash(endpoint.Password)),
        };

        httpClient.DefaultRequestHeaders.Accept.Clear();
        httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        if (!string.IsNullOrWhiteSpace(StationConstants.Ticket))
        {
            httpClient.DefaultRequestHeaders.Remove("AToken");
            var token = new AToken { TicketId = StationConstants.Ticket };
            if (!string.IsNullOrWhiteSpace(StationConstants.DeviceId))
            {
                token.DeviceId = StationConstants.DeviceId;
            }
            var aTokenJson = JsonSerializer.Serialize(token);
            httpClient.DefaultRequestHeaders.Add("AToken", aTokenJson);
        }

        using var response = await httpClient.PostAsJsonAsync(loginUrl, loginRequest, JsonOpts, ct);
        response.EnsureSuccessStatusCode();

        var loginResult = await response.Content.ReadFromJsonAsync<ResultStatus<LoginResult>>(JsonOpts, ct);
        if (loginResult?.objects?.TicketId is not { } ticketId)
            return null;

        // Sunucunun döndürdüğü değerlerle sabitleri güncelle
        StationConstants.Ticket = ticketId.ToString();
        StationConstants.TicketExpiry = loginResult.objects.ExpireDate;
        StationConstants.DeviceId = loginResult.objects.DeviceId?.ToString() ?? string.Empty;

        return loginResult;
    }

    public static string MD5Hash(string input)
    {
        MD5 md5Hasher = MD5.Create();
        byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
        StringBuilder sBuilder = new StringBuilder();
        for (int i = 0; i < data.Length; i++)
        {
            sBuilder.Append(data[i].ToString("x2"));
        }
        return sBuilder.ToString();
    }
}

