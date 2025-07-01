using Domain.Entities;
using Infrastructure.Persistence.Abstract;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Repositories;

public class CalibrationLimitRepository(IBKSContext context)
    : EfRepositoryBase<CalibrationLimit, int, IBKSContext>(context), ICalibrationLimitRepository
{
}
