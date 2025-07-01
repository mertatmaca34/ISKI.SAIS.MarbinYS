using Domain.Entities;
using Infrastructure.Persistence.Abstract;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Repositories;

public class MailSettingsRepository(IBKSContext context)
    : EfRepositoryBase<MailSetting, int, IBKSContext>(context), IMailSettingsRepository
{
}
