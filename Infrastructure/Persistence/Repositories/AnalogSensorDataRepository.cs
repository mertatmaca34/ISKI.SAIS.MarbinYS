using Domain.Entities;
using Infrastructure.Persistence.Abstract;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Repositories;

public class AnalogSensorDataRepository(IBKSContext context)
    : EfRepositoryBase<AnalogSensorData, int, IBKSContext>(context), IAnalogSensorDataRepository
{
}
