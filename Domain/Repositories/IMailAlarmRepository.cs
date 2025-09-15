using Domain.Entities;
using ISKI.Core.Infrastructure;

namespace Domain.Repositories;

public interface IMailAlarmRepository : IAsyncRepository<MailAlarm, int>
{
}

