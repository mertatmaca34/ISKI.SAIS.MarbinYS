using Domain.Entities;
using Infrastructure.Persistence.Abstract;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Repositories;

public class DigitalSensorDataRepository(IBKSContext context)
    : EfRepositoryBase<DigitalSensorData, int, IBKSContext>(context), IDigitalSensorDataRepository
{
}
