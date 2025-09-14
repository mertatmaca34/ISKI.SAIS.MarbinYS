using Domain.Entities;
using ISKI.Core.Infrastructure;

namespace Domain.Repositories;

public interface IUserRepository : IAsyncRepository<User, int>
{
}

