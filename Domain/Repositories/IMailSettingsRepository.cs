using Domain.Entities;
using ISKI.Core.Infrastructure;

namespace Domain.Repositories;

public interface IMailSettingsRepository : IAsyncRepository<MailSetting, int>
{
}
