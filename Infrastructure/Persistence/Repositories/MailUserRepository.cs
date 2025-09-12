using Domain.Entities;
using Domain.Repositories;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Repositories;

public class MailUserRepository(IBKSContext context)
    : EfRepositoryBase<MailUser, int, IBKSContext>(context), IMailUserRepository
{
}
