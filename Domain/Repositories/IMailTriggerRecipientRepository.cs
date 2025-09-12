using Domain.Entities;
using ISKI.Core.Infrastructure;

namespace Domain.Repositories;

public interface IMailTriggerRecipientRepository : IAsyncRepository<MailTriggerRecipient, int>
{
}
