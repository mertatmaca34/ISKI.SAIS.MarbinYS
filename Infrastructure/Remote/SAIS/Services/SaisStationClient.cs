using Infrastructure.Remote.SAIS.Configuration;
using Infrastructure.Remote.SAIS.DTOs.Requests;
using Infrastructure.Remote.SAIS.DTOs.Responses;
using Infrastructure.Remote.SAIS.Http;
using Infrastructure.Remote.SAIS.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Infrastructure.Remote.SAIS.Services;

internal sealed class SaisStationClient : SaisApiClientBase, ISaisStationClient
{
    public SaisStationClient(
        HttpClient httpClient,
        ILogger<SaisStationClient> logger,
        IOptions<SaisApiOptions> options,
        ISaisTicketProvider ticketProvider)
        : base(httpClient, logger, options, ticketProvider)
    {
    }

    public async Task<StationInformationResponse> GetStationInformationAsync(Guid stationId, CancellationToken cancellationToken)
    {
        var uri = BuildQuery(
            "SAIS/GetStationInformation",
            new Dictionary<string, string?>
            {
                ["stationId"] = stationId.ToString()
            });

        return await PostAsync<StationInformationResponse>(uri, payload: null, includeTicket: true, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task UpdateStationHostAsync(StationHostUpdateRequest request, CancellationToken cancellationToken)
    {
        await PostAsync<SaisEmptyResponse>(
                "SAIS/SendHostChanged",
                request,
                includeTicket: true,
                cancellationToken)
            .ConfigureAwait(false);
    }
}
