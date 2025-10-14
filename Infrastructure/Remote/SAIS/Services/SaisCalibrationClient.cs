using System.Globalization;
using Infrastructure.Remote.SAIS.Configuration;
using Infrastructure.Remote.SAIS.DTOs.Requests;
using Infrastructure.Remote.SAIS.DTOs.Responses;
using Infrastructure.Remote.SAIS.Http;
using Infrastructure.Remote.SAIS.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Infrastructure.Remote.SAIS.Services;

internal sealed class SaisCalibrationClient : SaisApiClientBase, ISaisCalibrationClient
{
    public SaisCalibrationClient(
        HttpClient httpClient,
        ILogger<SaisCalibrationClient> logger,
        IOptions<SaisApiOptions> options,
        ISaisTicketProvider ticketProvider)
        : base(httpClient, logger, options, ticketProvider)
    {
    }

    public Task SendCalibrationAsync(SendCalibrationRequest request, CancellationToken cancellationToken) =>
        PostAsync<SaisEmptyResponse>(
            "SAIS/SendCalibration",
            request,
            includeTicket: true,
            cancellationToken);

    public async Task<IReadOnlyCollection<CalibrationRecordResponse>> GetCalibrationsAsync(
        Guid stationId,
        DateTimeOffset startDate,
        DateTimeOffset endDate,
        CancellationToken cancellationToken)
    {
        var uri = BuildQuery(
            "SAIS/GetCalibration",
            new Dictionary<string, string?>
            {
                ["stationId"] = stationId.ToString(),
                ["startDate"] = startDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture),
                ["endDate"] = endDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)
            });

        return await PostAsync<IReadOnlyCollection<CalibrationRecordResponse>>(uri, payload: null, includeTicket: true, cancellationToken)
            .ConfigureAwait(false);
    }
}
