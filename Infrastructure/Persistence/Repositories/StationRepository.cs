using Application.Services.Repositories;
using Domain.Entities;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Repositories;

public class StationRepository(IBKSContext context)
    : EfRepositoryBase<Station, int, IBKSContext>(context), IStationRepository
{
}
