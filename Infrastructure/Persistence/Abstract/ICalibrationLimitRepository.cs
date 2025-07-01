using Domain.Entities;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Abstract;

public interface ICalibrationLimitRepository : IAsyncRepository<CalibrationLimit, int>
{
}
