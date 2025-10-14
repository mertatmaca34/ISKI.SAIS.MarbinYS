using Infrastructure.Remote.SAIS.DTOs.Requests;
using Infrastructure.Remote.SAIS.DTOs.Responses;

namespace Infrastructure.Remote.SAIS;

public interface ISaisDataClient
{
    Task<MeasurementDataResponse> SendMeasurementAsync(SendMeasurementRequest request, CancellationToken cancellationToken);

    Task<MeasurementDataResponse> GetLastMeasurementAsync(Guid stationId, int period, CancellationToken cancellationToken);

    Task<MissingDataResponse> GetMissingDatesAsync(Guid stationId, CancellationToken cancellationToken);

    Task<IReadOnlyCollection<MeasurementDataResponse>> GetMeasurementsAsync(
        Guid stationId,
        int period,
        DateTimeOffset startDate,
        DateTimeOffset endDate,
        CancellationToken cancellationToken);
}
