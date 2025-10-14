using System.Collections.Generic;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using Infrastructure.Remote.SAIS.Configuration;
using Infrastructure.Remote.SAIS.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Infrastructure.Remote.SAIS.Http;

internal abstract class SaisApiClientBase
{
    private static readonly JsonSerializerOptions SerializerOptions = new()
    {
        PropertyNamingPolicy = null,
        PropertyNameCaseInsensitive = true,
        DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    };

    private readonly HttpClient _httpClient;
    private readonly ILogger _logger;
    private readonly ISaisTicketProvider? _ticketProvider;
    private readonly SaisApiOptions _options;

    protected SaisApiClientBase(
        HttpClient httpClient,
        ILogger logger,
        IOptions<SaisApiOptions> options,
        ISaisTicketProvider? ticketProvider)
    {
        _httpClient = httpClient;
        _logger = logger;
        _ticketProvider = ticketProvider;
        _options = options.Value;

        if (string.IsNullOrWhiteSpace(_httpClient.BaseAddress?.ToString()))
        {
            _httpClient.BaseAddress = new Uri(_options.BaseUrl.TrimEnd('/') + "/", UriKind.Absolute);
        }
    }

    protected async Task<TResponse> PostAsync<TResponse>(
        string relativeUri,
        object? payload,
        bool includeTicket,
        CancellationToken cancellationToken)
    {
        using var request = new HttpRequestMessage(HttpMethod.Post, relativeUri)
        {
            Content = payload is null
                ? null
                : new StringContent(JsonSerializer.Serialize(payload, SerializerOptions), Encoding.UTF8, "application/json")
        };

        return await SendAsync<TResponse>(request, includeTicket, cancellationToken).ConfigureAwait(false);
    }

    protected async Task<TResponse> GetAsync<TResponse>(
        string relativeUri,
        bool includeTicket,
        CancellationToken cancellationToken)
    {
        using var request = new HttpRequestMessage(HttpMethod.Get, relativeUri);
        return await SendAsync<TResponse>(request, includeTicket, cancellationToken).ConfigureAwait(false);
    }

    protected static string BuildQuery(string relativeUri, IReadOnlyDictionary<string, string?> parameters)
    {
        if (parameters.Count == 0)
        {
            return relativeUri;
        }

        var builder = new StringBuilder(relativeUri);
        builder.Append(relativeUri.Contains('?') ? '&' : '?');

        var isFirst = true;
        foreach (var pair in parameters)
        {
            if (string.IsNullOrWhiteSpace(pair.Value))
            {
                continue;
            }

            if (!isFirst)
            {
                builder.Append('&');
            }

            builder.Append(Uri.EscapeDataString(pair.Key));
            builder.Append('=');
            builder.Append(Uri.EscapeDataString(pair.Value));

            isFirst = false;
        }

        return builder.ToString();
    }

    private async Task<TResponse> SendAsync<TResponse>(
        HttpRequestMessage request,
        bool includeTicket,
        CancellationToken cancellationToken)
    {
        if (includeTicket)
        {
            if (_ticketProvider is null)
            {
                throw new InvalidOperationException("Ticket provider has not been configured for this client.");
            }

            var ticket = await _ticketProvider.GetTicketAsync(cancellationToken).ConfigureAwait(false);
            var headerPayload = new Dictionary<string, string>
            {
                ["TicketId"] = ticket.TicketId,
            };

            if (!string.IsNullOrWhiteSpace(ticket.DeviceId))
            {
                headerPayload["DeviceId"] = ticket.DeviceId!;
            }

            var ticketHeaderValue = JsonSerializer.Serialize(headerPayload, SerializerOptions);

            request.Headers.Remove(_options.TicketHeaderName);
            request.Headers.TryAddWithoutValidation(_options.TicketHeaderName, ticketHeaderValue);
        }

        try
        {
            using var response = await _httpClient.SendAsync(request, cancellationToken).ConfigureAwait(false);

            if (response.StatusCode == HttpStatusCode.Unauthorized && includeTicket)
            {
                _ticketProvider?.InvalidateTicket();
            }

            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadFromJsonAsync<SaisResultEnvelope<TResponse>>(SerializerOptions, cancellationToken)
                         .ConfigureAwait(false);

            if (result is null)
            {
                throw new SaisApiException("SAİS API response body was empty.");
            }

            if (!result.Result)
            {
                throw new SaisApiException(result.Message ?? "SAİS API returned an unsuccessful result.");
            }

            if (result.Objects is null)
            {
                if (typeof(TResponse) == typeof(SaisEmptyResponse))
                {
                    return (TResponse)(object)new SaisEmptyResponse();
                }

                if (!typeof(TResponse).IsValueType || Nullable.GetUnderlyingType(typeof(TResponse)) is not null)
                {
                    return default!;
                }

                throw new SaisApiException("SAİS API response did not include an objects payload.");
            }

            return result.Objects;
        }
        catch (HttpRequestException ex)
        {
            _logger.LogError(ex, "SAİS API request to {Endpoint} failed.", request.RequestUri);
            throw new SaisApiException("SAİS API request failed.", ex);
        }
        catch (NotSupportedException ex)
        {
            _logger.LogError(ex, "SAİS API returned an unsupported media type for {Endpoint}.", request.RequestUri);
            throw new SaisApiException("SAİS API returned an unsupported media type.", ex);
        }
        catch (JsonException ex)
        {
            _logger.LogError(ex, "SAİS API response from {Endpoint} could not be parsed.", request.RequestUri);
            throw new SaisApiException("SAİS API response could not be parsed.", ex);
        }
    }
}

internal interface ISaisTicketProvider
{
    Task<SaisTicket> GetTicketAsync(CancellationToken cancellationToken);

    void InvalidateTicket();
}
