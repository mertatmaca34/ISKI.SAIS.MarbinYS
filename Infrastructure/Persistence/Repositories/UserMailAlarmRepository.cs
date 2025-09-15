using Domain.Entities;
using Domain.Repositories;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Repositories;

public class UserMailAlarmRepository(IBKSContext context)
    : EfRepositoryBase<UserMailAlarm, int, IBKSContext>(context), IUserMailAlarmRepository
{
}

