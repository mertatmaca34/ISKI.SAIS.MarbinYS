using Domain.Entities;
using Domain.Repositories;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Repositories;

public class CalibrationMeasurementRepository(IBKSContext context)
    : EfRepositoryBase<CalibrationMeasurement, int, IBKSContext>(context), ICalibrationMeasurementRepository
{
}
