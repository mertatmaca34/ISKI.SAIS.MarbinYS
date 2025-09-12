using Domain.Entities;
using Domain.Repositories;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Repositories;

public class PlcInformationRepository(IBKSContext context)
    : EfRepositoryBase<PlcInformation, int, IBKSContext>(context), IPlcInformationRepository
{
}
