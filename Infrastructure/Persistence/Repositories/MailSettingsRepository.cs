using Application.Services.Repositories;
using Domain.Entities;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Repositories;

public class MailSettingsRepository(IBKSContext context)
    : EfRepositoryBase<MailSettings, int, IBKSContext>(context), IMailSettingsRepository
{
}
