using Domain.Entities;
using Domain.Repositories;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Repositories;

public class MailTriggerRecipientRepository(IBKSContext context)
    : EfRepositoryBase<MailTriggerRecipient, int, IBKSContext>(context), IMailTriggerRecipientRepository
{
}
