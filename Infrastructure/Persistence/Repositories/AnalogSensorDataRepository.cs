using Application.Services.Repositories;
using Domain.Entities;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Repositories;

public class AnalogSensorDataRepository(IBKSContext context)
    : EfRepositoryBase<AnalogSensorData, int, IBKSContext>(context), IAnalogSensorDataRepository
{
}
