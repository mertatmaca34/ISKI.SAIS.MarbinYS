using Domain.Entities;
using Domain.Repositories;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Repositories;

public class MailAlarmRepository(IBKSContext context)
    : EfRepositoryBase<MailAlarm, int, IBKSContext>(context), IMailAlarmRepository
{
}

