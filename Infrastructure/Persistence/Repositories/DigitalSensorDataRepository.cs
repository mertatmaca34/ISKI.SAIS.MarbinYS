using Domain.Entities;
using Domain.Repositories;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Repositories;

public class DigitalSensorDataRepository(IBKSContext context)
    : EfRepositoryBase<DigitalSensorData, int, IBKSContext>(context), IDigitalSensorDataRepository
{
}
