using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using WinUI.Constants;
using WinUI.Models;

namespace WinUI.Services;

public interface ITicketService
{
    TicketSession? CurrentTicket { get; }
    bool HasValidTicket();
    Task EnsureTicketAsync();
    Task<ResultStatus<LoginResult>?> RefreshTicketAsync(CancellationToken ct = default);
    bool TryApplyTicket(HttpRequestHeaders headers);
}

public sealed record TicketSession(string TicketId, DateTime Expiration, string? DeviceId);

public class TicketService(HttpClient httpClient, IApiEndpointService apiEndpointService, ILogger<TicketService> logger) : ITicketService
{
    private const string TicketHeaderName = "Ticket";
    private static readonly JsonSerializerOptions JsonOpts = new();

    public TicketSession? CurrentTicket { get; private set; } = CreateSessionFromConstants();

    public bool HasValidTicket()
    {
        return CurrentTicket is { TicketId.Length: > 0, Expiration: var expiry } && DateTime.Now < expiry;
    }

    public async Task EnsureTicketAsync()
    {
        if (HasValidTicket())
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

        using var response = await httpClient.PostAsJsonAsync(loginUrl, loginRequest, JsonOpts, ct);
        response.EnsureSuccessStatusCode();

        var loginResult = await response.Content.ReadFromJsonAsync<ResultStatus<LoginResult>>(JsonOpts, ct);
        if (loginResult?.objects?.TicketId is not { } ticketId)
        {
            return null;
        }

        var deviceId = loginResult.objects.DeviceId?.ToString();
        var session = new TicketSession(ticketId.ToString(), loginResult.objects.User.ExpireDate, string.IsNullOrWhiteSpace(deviceId) ? null : deviceId);
        UpdateSession(session);

        return loginResult;
    }

    public bool TryApplyTicket(HttpRequestHeaders headers)
    {
        ArgumentNullException.ThrowIfNull(headers);

        headers.Remove(TicketHeaderName);

        if (!HasValidTicket())
        {
            return false;
        }

        var ticket = CurrentTicket!;
        var payload = new Dictionary<string, string>
        {
            ["TicketId"] = ticket.TicketId,
        };

        if (!string.IsNullOrWhiteSpace(ticket.DeviceId))
        {
            payload["DeviceId"] = ticket.DeviceId!;
        }

        var serialized = JsonSerializer.Serialize(payload, JsonOpts);
        headers.Add(TicketHeaderName, serialized);
        return true;
    }

    public static string MD5Hash(string input)
    {
        using MD5 md5Hasher = MD5.Create();
        byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
        StringBuilder sBuilder = new();
        for (int i = 0; i < data.Length; i++)
        {
            sBuilder.Append(data[i].ToString("x2"));
        }

        return sBuilder.ToString();
    }

    private static TicketSession? CreateSessionFromConstants()
    {
        if (string.IsNullOrWhiteSpace(StationConstants.Ticket))
        {
            return null;
        }

        var deviceId = string.IsNullOrWhiteSpace(StationConstants.DeviceId) ? null : StationConstants.DeviceId;
        return new TicketSession(StationConstants.Ticket, StationConstants.TicketExpiry, deviceId);
    }

    private void UpdateSession(TicketSession session)
    {
        CurrentTicket = session;
        StationConstants.Ticket = session.TicketId;
        StationConstants.TicketExpiry = session.Expiration;
        StationConstants.DeviceId = session.DeviceId ?? string.Empty;
    }
}
