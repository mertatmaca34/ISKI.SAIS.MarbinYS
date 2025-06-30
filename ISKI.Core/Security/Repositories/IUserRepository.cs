using ISKI.Core.Security.Entities;
using ISKI.Core.Infrastructure;

namespace ISKI.Core.Security.Repositories;

public interface IUserRepository : IAsyncRepository<User, Guid>
{
}
