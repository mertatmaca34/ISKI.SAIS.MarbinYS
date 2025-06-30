using Application.Services.Repositories;
using Domain.Entities;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Repositories;

public class MailUserRepository(IBKSContext context)
    : EfRepositoryBase<MailUser, int, IBKSContext>(context), IMailUserRepository
{
}
