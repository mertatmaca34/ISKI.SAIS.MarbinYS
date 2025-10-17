using Infrastructure.Remote.SAIS.Configuration;
using Infrastructure.Remote.SAIS.Http;
using Infrastructure.Remote.SAIS.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Infrastructure.Remote.SAIS.Services;

internal sealed class SaisTicketProvider : ISaisTicketProvider
{
    private readonly SemaphoreSlim _lock = new(1, 1);
    private readonly ILogger<SaisTicketProvider> _logger;
    private readonly ISaisSecurityClient _securityClient;
    private readonly SaisApiOptions _options;

    private SaisTicket? _currentTicket;

    public SaisTicketProvider(
        ISaisSecurityClient securityClient,
        IOptions<SaisApiOptions> options,
        ILogger<SaisTicketProvider> logger)
    {
        _securityClient = securityClient;
        _logger = logger;
        _options = options.Value;
    }

    public async Task<SaisTicket> GetTicketAsync(CancellationToken cancellationToken)
    {
        if (_currentTicket is { } existingTicket && existingTicket.ExpiresAt > DateTimeOffset.Now)
        {
            return existingTicket;
        }

        await _lock.WaitAsync(cancellationToken).ConfigureAwait(false);
        try
        {
            if (_currentTicket is { } cachedTicket && cachedTicket.ExpiresAt > DateTimeOffset.Now)
            {
                return cachedTicket;
            }

            _logger.LogInformation("Requesting new SAİS API ticket.");
            var credentials = await _securityClient.LoginAsync(cancellationToken).ConfigureAwait(false);
            var ticketId = credentials.TicketId;
            var expiresAt = DateTimeOffset.Now.AddMinutes(30) - _options.TicketRenewalOffset;
            _currentTicket = new SaisTicket(ticketId, expiresAt, credentials.DeviceId);

            return _currentTicket;
        }
        finally
        {
            _lock.Release();
        }
    }

    public void InvalidateTicket()
    {
        _currentTicket = null;
    }
}
