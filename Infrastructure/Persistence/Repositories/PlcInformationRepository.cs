using Domain.Entities;
using Infrastructure.Persistence.Abstract;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Repositories;

public class PlcInformationRepository(IBKSContext context)
    : EfRepositoryBase<PlcInformation, int, IBKSContext>(context), IPlcInformationRepository
{
}
