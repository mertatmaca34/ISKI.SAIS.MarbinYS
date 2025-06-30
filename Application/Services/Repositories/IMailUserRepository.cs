using Domain.Entities;
using ISKI.Core.Infrastructure;

namespace Application.Services.Repositories;

public interface IMailUserRepository : IAsyncRepository<MailUser, int>
{
}
