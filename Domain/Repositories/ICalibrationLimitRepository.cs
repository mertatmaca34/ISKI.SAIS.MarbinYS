using Domain.Entities;
using ISKI.Core.Infrastructure;

namespace Domain.Repositories;

public interface ICalibrationLimitRepository : IAsyncRepository<CalibrationLimit, int>
{
}
