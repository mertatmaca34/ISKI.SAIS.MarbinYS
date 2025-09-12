using Domain.Entities;
using Domain.Repositories;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Repositories;

public class MailTriggerRepository(IBKSContext context)
    : EfRepositoryBase<MailTrigger, int, IBKSContext>(context), IMailTriggerRepository
{
}
