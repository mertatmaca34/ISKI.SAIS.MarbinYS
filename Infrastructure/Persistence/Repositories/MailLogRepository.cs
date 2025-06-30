using Application.Services.Repositories;
using Domain.Entities;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Repositories;

public class MailLogRepository(IBKSContext context)
    : EfRepositoryBase<MailLog, int, IBKSContext>(context), IMailLogRepository
{
}
