using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WinUI.Constants;
using WinUI.Models;

namespace WinUI.Services;

public interface ITicketService
{
    Task EnsureTicketAsync();
    Task<LoginResult?> RefreshTicketAsync();
}

public class TicketService(HttpClient httpClient, IApiEndpointService apiEndpointService) : ITicketService
{
    public async Task EnsureTicketAsync()
    {
        if (!string.IsNullOrEmpty(StationConstants.Ticket) && DateTime.UtcNow < StationConstants.TicketExpiry)
        {
            return;
        }

        await RefreshTicketAsync();
    }

    public async Task<LoginResult?> RefreshTicketAsync()
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
            password = endpoint.Password,
            ticket = StationConstants.Ticket
        };

        using var response = await httpClient.PostAsJsonAsync(loginUrl, loginRequest);
        response.EnsureSuccessStatusCode();
        var loginResult = await response.Content.ReadFromJsonAsync<LoginResult>();
        StationConstants.Ticket = loginResult?.TicketId?.ToString();
        StationConstants.TicketExpiry = DateTime.UtcNow.AddMinutes(30);
        return loginResult;
    }
}

