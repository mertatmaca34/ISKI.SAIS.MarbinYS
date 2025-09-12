using Domain.Entities;
using ISKI.Core.Infrastructure;

namespace Domain.Repositories;

public interface ICalibrationMeasurementRepository : IAsyncRepository<CalibrationMeasurement, int>
{
}
