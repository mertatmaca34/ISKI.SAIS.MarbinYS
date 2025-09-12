using Domain.Entities;
using ISKI.Core.Infrastructure;

namespace Domain.Repositories;

public interface IMailTriggerRepository : IAsyncRepository<MailTrigger, int>
{
}
