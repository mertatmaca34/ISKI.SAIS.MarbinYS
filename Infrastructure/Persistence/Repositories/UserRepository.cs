using Domain.Entities;
using Domain.Repositories;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Repositories;

public class UserRepository(IBKSContext context)
    : EfRepositoryBase<User, int, IBKSContext>(context), IUserRepository
{
}

