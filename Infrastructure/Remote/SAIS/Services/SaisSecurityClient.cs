using Infrastructure.Remote.SAIS.Configuration;
using Infrastructure.Remote.SAIS.DTOs.Requests;
using Infrastructure.Remote.SAIS.DTOs.Responses;
using Infrastructure.Remote.SAIS.Http;
using Infrastructure.Remote.SAIS.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Infrastructure.Remote.SAIS.Services;

internal sealed class SaisSecurityClient : SaisApiClientBase, ISaisSecurityClient
{
    private readonly SaisApiOptions _options;

    public SaisSecurityClient(
        HttpClient httpClient,
        ILogger<SaisSecurityClient> logger,
        IOptions<SaisApiOptions> options)
        : base(httpClient, logger, options, ticketProvider: null)
    {
        _options = options.Value;
    }

    public async Task<string> LoginAsync(CancellationToken cancellationToken)
    {
        var payload = new LoginRequest
        {
            Username = _options.Username,
            PasswordHash = _options.PasswordHash
        };

        var response = await PostAsync<LoginResponse>(
                "Security/login",
                payload,
                includeTicket: false,
                cancellationToken)
            .ConfigureAwait(false);

        if (string.IsNullOrWhiteSpace(response.TicketId))
        {
            throw new SaisApiException("SAİS API login response did not contain a ticket identifier.");
        }

        return response.TicketId;
    }
}
