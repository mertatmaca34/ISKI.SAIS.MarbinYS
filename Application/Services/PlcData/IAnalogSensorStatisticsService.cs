using Application.Features.PlcData.Dtos;

namespace Application.Services.PlcData;

public interface IAnalogSensorStatisticsService
{
    Task<AnalogSensorAverageDto> GetHourlyAverageAsync(DateTime referenceTime, CancellationToken cancellationToken = default);
}
