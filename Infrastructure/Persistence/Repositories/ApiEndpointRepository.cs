using Domain.Entities;
using Infrastructure.Persistence.Abstract;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Repositories;

public class ApiEndpointRepository(IBKSContext context)
    : EfRepositoryBase<ApiEndpoint, int, IBKSContext>(context), IApiEndpointRepository
{
}
