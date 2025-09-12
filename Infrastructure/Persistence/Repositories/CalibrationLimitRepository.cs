using Domain.Entities;
using Domain.Repositories;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Repositories;

public class CalibrationLimitRepository(IBKSContext context)
    : EfRepositoryBase<CalibrationLimit, int, IBKSContext>(context), ICalibrationLimitRepository
{
}
