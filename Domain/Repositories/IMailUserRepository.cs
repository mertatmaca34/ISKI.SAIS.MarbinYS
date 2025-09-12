using Domain.Entities;
using ISKI.Core.Infrastructure;

namespace Domain.Repositories;

public interface IMailUserRepository : IAsyncRepository<MailUser, int>
{
}
