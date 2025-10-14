using System.Globalization;
using Infrastructure.Remote.SAIS.Configuration;
using Infrastructure.Remote.SAIS.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Infrastructure.Remote.SAIS.Services;

internal sealed class SaisTimeClient : SaisApiClientBase, ISaisTimeClient
{
    public SaisTimeClient(
        HttpClient httpClient,
        ILogger<SaisTimeClient> logger,
        IOptions<SaisApiOptions> options,
        ISaisTicketProvider ticketProvider)
        : base(httpClient, logger, options, ticketProvider)
    {
    }

    public async Task<DateTimeOffset> GetServerDateTimeAsync(CancellationToken cancellationToken)
    {
        var response = await PostAsync<string>(
                "SAIS/GetServerDateTime",
                payload: null,
                includeTicket: true,
                cancellationToken)
            .ConfigureAwait(false);

        return DateTimeOffset.Parse(response, CultureInfo.InvariantCulture);
    }
}
