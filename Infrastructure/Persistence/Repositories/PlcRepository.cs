using Application.Services.Repositories;
using Domain.Entities;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Repositories;

public class PlcRepository(IBKSContext context)
    : EfRepositoryBase<Plc, int, IBKSContext>(context), IPlcRepository
{
}
