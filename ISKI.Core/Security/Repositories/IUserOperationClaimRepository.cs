using ISKI.Core.Security.Entities;
using ISKI.Core.Infrastructure;

namespace ISKI.Core.Security.Repositories;

public interface IUserOperationClaimRepository : IAsyncRepository<UserOperationClaim, int>
{
    Task<List<OperationClaim>> GetClaims(User user);

}
