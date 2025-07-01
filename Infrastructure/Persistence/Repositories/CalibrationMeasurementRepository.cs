using Application.Services.Repositories;
using Domain.Entities;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Repositories;

public class CalibrationMeasurementRepository(IBKSContext context)
    : EfRepositoryBase<CalibrationMeasurement, int, IBKSContext>(context), ICalibrationMeasurementRepository
{
}
