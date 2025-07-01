using Application.Services.Repositories;
using Domain.Entities;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Repositories;

public class DigitalSensorDataRepository(IBKSContext context)
    : EfRepositoryBase<DigitalSensorData, int, IBKSContext>(context), IDigitalSensorDataRepository
{
}
