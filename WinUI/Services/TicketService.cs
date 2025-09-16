using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Extensions.Logging;
using WinUI.Constants;
using WinUI.Models;

namespace WinUI.Services;

public interface ITicketService
{
    Task EnsureTicketAsync();
    Task<ResultStatus<LoginResult>?> RefreshTicketAsync();
}

public class TicketService(HttpClient httpClient, IApiEndpointService apiEndpointService, ILogger<TicketService> logger) : ITicketService
{
    public async Task EnsureTicketAsync()
    {
        if (!string.IsNullOrEmpty(StationConstants.Ticket) && DateTime.Now < StationConstants.TicketExpiry)
        {
            return;
        }

        logger.LogWarning("SAIS ticket missing or expired. Refreshing ticket.");
        await RefreshTicketAsync();
    }

    public async Task<ResultStatus<LoginResult>?> RefreshTicketAsync()
    {
        var endpoint = await apiEndpointService.GetFirstAsync();
        if (endpoint == null)
        {
            return null;
        }

        var loginUrl = $"{endpoint.ApiAddress.TrimEnd('/')}/Security/login";
        var loginRequest = new
        {
            username = endpoint.UserName,
            password = DoubleMd5(endpoint.Password),
        };

        using var response = await httpClient.PostAsJsonAsync(loginUrl, loginRequest);
        response.EnsureSuccessStatusCode();
        var loginResult = await response.Content.ReadFromJsonAsync<ResultStatus<LoginResult>>();
        if (loginResult?.objects?.TicketId is not { } ticketId)
        {
            return null;
        }

        StationConstants.Ticket = loginResult.objects.TicketId.ToString()!;
        StationConstants.TicketExpiry = loginResult.objects.ExpireDate;
        return loginResult;
    }

    private static string DoubleMd5(string password)
    {
        using var md5 = MD5.Create();
        var first = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
        var second = md5.ComputeHash(first);
        return Convert.ToHexString(second).ToLowerInvariant();
    }
}

