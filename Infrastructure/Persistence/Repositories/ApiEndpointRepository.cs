using Domain.Entities;
using Domain.Repositories;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Repositories;

public class ApiEndpointRepository(IBKSContext context)
    : EfRepositoryBase<ApiEndpoint, int, IBKSContext>(context), IApiEndpointRepository
{
}
