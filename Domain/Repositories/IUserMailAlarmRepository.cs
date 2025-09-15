using Domain.Entities;
using ISKI.Core.Infrastructure;

namespace Domain.Repositories;

public interface IUserMailAlarmRepository : IAsyncRepository<UserMailAlarm, int>
{
}

