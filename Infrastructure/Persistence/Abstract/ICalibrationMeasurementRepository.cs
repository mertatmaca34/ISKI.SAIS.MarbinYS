using Domain.Entities;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Abstract;

public interface ICalibrationMeasurementRepository : IAsyncRepository<CalibrationMeasurement, int>
{
}
