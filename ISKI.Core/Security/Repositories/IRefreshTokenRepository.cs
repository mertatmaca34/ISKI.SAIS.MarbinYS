using ISKI.Core.Security.Entities;
using ISKI.Core.Infrastructure;
using ISKI.Core.Security.JWT;

namespace ISKI.Core.Security.Repositories;

public interface IRefreshTokenRepository : IAsyncRepository<RefreshToken, Guid>
{
}
