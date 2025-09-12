using Domain.Entities;
using Domain.Repositories;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Repositories;

public class StationRepository(IBKSContext context)
    : EfRepositoryBase<Station, int, IBKSContext>(context), IStationRepository
{
}
