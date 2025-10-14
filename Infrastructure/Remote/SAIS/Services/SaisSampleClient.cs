using Infrastructure.Remote.SAIS.Configuration;
using Infrastructure.Remote.SAIS.DTOs.Requests;
using Infrastructure.Remote.SAIS.Http;
using Infrastructure.Remote.SAIS.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Infrastructure.Remote.SAIS.Services;

internal sealed class SaisSampleClient : SaisApiClientBase, ISaisSampleClient
{
    public SaisSampleClient(
        HttpClient httpClient,
        ILogger<SaisSampleClient> logger,
        IOptions<SaisApiOptions> options,
        ISaisTicketProvider ticketProvider)
        : base(httpClient, logger, options, ticketProvider)
    {
    }

    public Task NotifySampleStartAsync(SampleRequestStartRequest request, CancellationToken cancellationToken) =>
        PostAsync<SaisEmptyResponse>("SAIS/SampleRequestStart", request, includeTicket: true, cancellationToken);

    public Task<string> NotifySampleStartForLimitAsync(SampleLimitRequest request, CancellationToken cancellationToken) =>
        PostAsync<string>("SAIS/SampleRequestLimitOver", request, includeTicket: true, cancellationToken);

    public Task CompleteSampleAsync(SampleStatusUpdateRequest request, CancellationToken cancellationToken) =>
        PostAsync<SaisEmptyResponse>("SAIS/SampleRequestComplete", request, includeTicket: true, cancellationToken);

    public Task ReportSampleErrorAsync(SampleStatusUpdateRequest request, CancellationToken cancellationToken) =>
        PostAsync<SaisEmptyResponse>("SAIS/SampleRequestError", request, includeTicket: true, cancellationToken);
}
