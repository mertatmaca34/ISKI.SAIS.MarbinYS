using Application.Services.Repositories;
using Domain.Entities;
using ISKI.Core.Infrastructure;

namespace Infrastructure.Persistence.Repositories;

public class SendDataRepository(IBKSContext context)
    : EfRepositoryBase<SendData, int, IBKSContext>(context), ISendDataRepository
{
}
