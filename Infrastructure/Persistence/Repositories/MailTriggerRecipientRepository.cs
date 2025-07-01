using Domain.Entities;
using Infrastructure.Persistence.Abstract;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Repositories;

public class MailTriggerRecipientRepository(IBKSContext context)
    : EfRepositoryBase<MailTriggerRecipient, int, IBKSContext>(context), IMailTriggerRecipientRepository
{
}
