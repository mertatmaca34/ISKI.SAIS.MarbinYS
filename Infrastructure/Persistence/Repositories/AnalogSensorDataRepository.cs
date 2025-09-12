using Domain.Entities;
using Domain.Repositories;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Repositories;

public class AnalogSensorDataRepository(IBKSContext context)
    : EfRepositoryBase<AnalogSensorData, int, IBKSContext>(context), IAnalogSensorDataRepository
{
}
