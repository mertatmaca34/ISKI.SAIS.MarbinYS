using Application.Services.Repositories;
using Domain.Entities;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Repositories;

public class ApiEndpointRepository(IBKSContext context)
    : EfRepositoryBase<ApiEndpoint, int, IBKSContext>(context), IApiEndpointRepository
{
}
