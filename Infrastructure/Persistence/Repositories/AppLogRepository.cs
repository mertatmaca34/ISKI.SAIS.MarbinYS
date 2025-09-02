using Domain.Entities;
using Infrastructure.Persistence.Abstract;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Repositories;

public class AppLogRepository(IBKSContext context)
    : EfRepositoryBase<AppLog, int, IBKSContext>(context), IAppLogRepository
{
}
