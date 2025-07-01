using Domain.Entities;
using Infrastructure.Persistence.Abstract;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Repositories;

public class MailUserRepository(IBKSContext context)
    : EfRepositoryBase<MailUser, int, IBKSContext>(context), IMailUserRepository
{
}
