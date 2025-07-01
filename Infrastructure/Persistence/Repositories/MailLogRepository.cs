using Domain.Entities;
using Infrastructure.Persistence.Abstract;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Repositories;

public class MailLogRepository(IBKSContext context)
    : EfRepositoryBase<MailLog, int, IBKSContext>(context), IMailLogRepository
{
}
