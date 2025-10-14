using System.Globalization;
using Infrastructure.Remote.SAIS.Configuration;
using Infrastructure.Remote.SAIS.DTOs.Requests;
using Infrastructure.Remote.SAIS.DTOs.Responses;
using Infrastructure.Remote.SAIS.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Infrastructure.Remote.SAIS.Services;

internal sealed class SaisDataClient : SaisApiClientBase, ISaisDataClient
{
    public SaisDataClient(
        HttpClient httpClient,
        ILogger<SaisDataClient> logger,
        IOptions<SaisApiOptions> options,
        ISaisTicketProvider ticketProvider)
        : base(httpClient, logger, options, ticketProvider)
    {
    }

    public Task<MeasurementDataResponse> SendMeasurementAsync(SendMeasurementRequest request, CancellationToken cancellationToken) =>
        PostAsync<MeasurementDataResponse>(
            "SAIS/SendData",
            request,
            includeTicket: true,
            cancellationToken);

    public async Task<MeasurementDataResponse> GetLastMeasurementAsync(Guid stationId, int period, CancellationToken cancellationToken)
    {
        var uri = BuildQuery(
            "SAIS/GetLastData",
            new Dictionary<string, string?>
            {
                ["stationId"] = stationId.ToString(),
                ["period"] = period.ToString(CultureInfo.InvariantCulture)
            });

        return await PostAsync<MeasurementDataResponse>(uri, payload: null, includeTicket: true, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<MissingDataResponse> GetMissingDatesAsync(Guid stationId, CancellationToken cancellationToken)
    {
        var uri = BuildQuery(
            "SAIS/GetMissingDates",
            new Dictionary<string, string?>
            {
                ["stationId"] = stationId.ToString()
            });

        return await PostAsync<MissingDataResponse>(uri, payload: null, includeTicket: true, cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<IReadOnlyCollection<MeasurementDataResponse>> GetMeasurementsAsync(
        Guid stationId,
        int period,
        DateTimeOffset startDate,
        DateTimeOffset endDate,
        CancellationToken cancellationToken)
    {
        var uri = BuildQuery(
            "SAIS/GetDataByBetweenTwoDate",
            new Dictionary<string, string?>
            {
                ["stationId"] = stationId.ToString(),
                ["period"] = period.ToString(CultureInfo.InvariantCulture),
                ["startDate"] = startDate.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                ["endDate"] = endDate.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)
            });

        return await PostAsync<IReadOnlyCollection<MeasurementDataResponse>>(uri, payload: null, includeTicket: true, cancellationToken)
            .ConfigureAwait(false);
    }
}
