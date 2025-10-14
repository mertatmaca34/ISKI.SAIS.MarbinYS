using Infrastructure.Remote.SAIS.Configuration;
using Infrastructure.Remote.SAIS.DTOs.Requests;
using Infrastructure.Remote.SAIS.DTOs.Responses;
using Infrastructure.Remote.SAIS.Http;
using Infrastructure.Remote.SAIS.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Infrastructure.Remote.SAIS.Services;

internal sealed class SaisChannelClient : SaisApiClientBase, ISaisChannelClient
{
    public SaisChannelClient(
        HttpClient httpClient,
        ILogger<SaisChannelClient> logger,
        IOptions<SaisApiOptions> options,
        ISaisTicketProvider ticketProvider)
        : base(httpClient, logger, options, ticketProvider)
    {
    }

    public async Task<IReadOnlyCollection<ChannelInformationResponse>> GetChannelsAsync(Guid stationId, CancellationToken cancellationToken)
    {
        var uri = BuildQuery(
            "SAIS/GetChannelInformationByStationId",
            new Dictionary<string, string?>
            {
                ["stationId"] = stationId.ToString()
            });

        return await PostAsync<IReadOnlyCollection<ChannelInformationResponse>>(uri, payload: null, includeTicket: true, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task UpdateChannelAsync(ChannelUpdateRequest request, CancellationToken cancellationToken)
    {
        await PostAsync<SaisEmptyResponse>("SAIS/UpdateChannelInformation", request, includeTicket: true, cancellationToken)
            .ConfigureAwait(false);
    }
}
