using Application.Services.Repositories;
using Domain.Entities;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Repositories;

public class CalibrationLimitRepository(IBKSContext context)
    : EfRepositoryBase<CalibrationLimit, int, IBKSContext>(context), ICalibrationLimitRepository
{
}
