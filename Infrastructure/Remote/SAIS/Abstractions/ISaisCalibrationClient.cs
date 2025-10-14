using Infrastructure.Remote.SAIS.DTOs.Requests;
using Infrastructure.Remote.SAIS.DTOs.Responses;

namespace Infrastructure.Remote.SAIS;

public interface ISaisCalibrationClient
{
    Task SendCalibrationAsync(SendCalibrationRequest request, CancellationToken cancellationToken);

    Task<IReadOnlyCollection<CalibrationRecordResponse>> GetCalibrationsAsync(
        Guid stationId,
        DateTimeOffset startDate,
        DateTimeOffset endDate,
        CancellationToken cancellationToken);
}
