using Domain.Entities;
using Domain.Repositories;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Repositories;

public class MailSettingsRepository(IBKSContext context)
    : EfRepositoryBase<MailSetting, int, IBKSContext>(context), IMailSettingsRepository
{
}
