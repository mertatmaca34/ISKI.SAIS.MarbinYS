using Domain.Entities;
using Domain.Repositories;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Repositories;

public class MailLogRepository(IBKSContext context)
    : EfRepositoryBase<MailLog, int, IBKSContext>(context), IMailLogRepository
{
}
