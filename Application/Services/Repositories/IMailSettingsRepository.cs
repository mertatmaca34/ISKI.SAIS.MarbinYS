using Domain.Entities;
using ISKI.Core.Infrastructure;

namespace Application.Services.Repositories;

public interface IMailSettingsRepository : IAsyncRepository<MailSettings, int>
{
}
