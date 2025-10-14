using Infrastructure.Remote.SAIS.Configuration;
using Infrastructure.Remote.SAIS.DTOs.Requests;
using Infrastructure.Remote.SAIS.DTOs.Responses;
using Infrastructure.Remote.SAIS.Http;
using Infrastructure.Remote.SAIS.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Infrastructure.Remote.SAIS.Services;

internal sealed class SaisDiagnosticClient : SaisApiClientBase, ISaisDiagnosticClient
{
    public SaisDiagnosticClient(
        HttpClient httpClient,
        ILogger<SaisDiagnosticClient> logger,
        IOptions<SaisApiOptions> options,
        ISaisTicketProvider ticketProvider)
        : base(httpClient, logger, options, ticketProvider)
    {
    }

    public Task<IReadOnlyCollection<DiagnosticTypeResponse>> GetDiagnosticTypesAsync(CancellationToken cancellationToken) =>
        PostAsync<IReadOnlyCollection<DiagnosticTypeResponse>>(
            "SAIS/GetDiagnosticTypes",
            payload: null,
            includeTicket: true,
            cancellationToken);

    public Task SendDiagnosticAsync(SendDiagnosticRequest request, CancellationToken cancellationToken) =>
        PostAsync<SaisEmptyResponse>("SAIS/SendDiagnostic", request, includeTicket: true, cancellationToken);

    public Task SendDiagnosticAsync(SendDiagnosticWithTypeRequest request, CancellationToken cancellationToken) =>
        PostAsync<SaisEmptyResponse>("SAIS/SendDiagnosticWithTypeNo", request, includeTicket: true, cancellationToken);

    public Task SendPowerOffNotificationAsync(PowerOffNotificationRequest request, CancellationToken cancellationToken) =>
        PostAsync<SaisEmptyResponse>("SAIS/SendPowerOffTime", request, includeTicket: true, cancellationToken);
}
