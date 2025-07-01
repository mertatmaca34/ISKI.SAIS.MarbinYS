using Domain.Entities;
using Infrastructure.Persistence.Abstract;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Repositories;

public class CalibrationMeasurementRepository(IBKSContext context)
    : EfRepositoryBase<CalibrationMeasurement, int, IBKSContext>(context), ICalibrationMeasurementRepository
{
}
