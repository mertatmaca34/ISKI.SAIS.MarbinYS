using Domain.Entities;
using ISKI.Core.Infrastructure;

namespace Domain.Repositories;

public interface IApiEndpointRepository : IAsyncRepository<ApiEndpoint, int>
{
}
