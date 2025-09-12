using Domain.Entities;
using ISKI.Core.Infrastructure;

namespace Domain.Repositories;

public interface IMailLogRepository : IAsyncRepository<MailLog, int>
{
}
