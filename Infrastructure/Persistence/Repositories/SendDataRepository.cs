using Domain.Entities;
using Infrastructure.Persistence.Abstract;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Repositories;

public class SendDataRepository(IBKSContext context)
    : EfRepositoryBase<SendData, int, IBKSContext>(context), ISendDataRepository
{
}
