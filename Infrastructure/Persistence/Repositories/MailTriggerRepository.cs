using Domain.Entities;
using Infrastructure.Persistence.Abstract;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Repositories;

public class MailTriggerRepository(IBKSContext context)
    : EfRepositoryBase<MailTrigger, int, IBKSContext>(context), IMailTriggerRepository
{
}
