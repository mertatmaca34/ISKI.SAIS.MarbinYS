using Infrastructure.Remote.SAIS.Configuration;
using Infrastructure.Remote.SAIS.DTOs.Responses;
using Infrastructure.Remote.SAIS.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Infrastructure.Remote.SAIS.Services;

internal sealed class SaisGeneralInformationClient : SaisApiClientBase, ISaisGeneralInformationClient
{
    public SaisGeneralInformationClient(
        HttpClient httpClient,
        ILogger<SaisGeneralInformationClient> logger,
        IOptions<SaisApiOptions> options,
        ISaisTicketProvider ticketProvider)
        : base(httpClient, logger, options, ticketProvider)
    {
    }

    public Task<IReadOnlyCollection<ParameterInformationResponse>> GetParametersAsync(CancellationToken cancellationToken) =>
        PostAsync<IReadOnlyCollection<ParameterInformationResponse>>(
            "SAIS/GetParameters",
            payload: null,
            includeTicket: true,
            cancellationToken);

    public Task<IReadOnlyCollection<UnitInformationResponse>> GetUnitsAsync(CancellationToken cancellationToken) =>
        PostAsync<IReadOnlyCollection<UnitInformationResponse>>(
            "SAIS/GetUnits",
            payload: null,
            includeTicket: true,
            cancellationToken);

    public Task<IReadOnlyCollection<DataStatusResponse>> GetDataStatusesAsync(CancellationToken cancellationToken) =>
        PostAsync<IReadOnlyCollection<DataStatusResponse>>(
            "SAIS/GetDataStatusDescription",
            payload: null,
            includeTicket: true,
            cancellationToken);
}
