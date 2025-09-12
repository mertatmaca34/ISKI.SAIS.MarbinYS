using Domain.Entities;
using ISKI.Core.Infrastructure;

namespace Domain.Repositories;

public interface ISendDataRepository : IAsyncRepository<SendData, int>
{
}
