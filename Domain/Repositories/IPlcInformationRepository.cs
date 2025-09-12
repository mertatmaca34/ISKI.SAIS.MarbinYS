using Domain.Entities;
using ISKI.Core.Infrastructure;

namespace Domain.Repositories;

public interface IPlcInformationRepository : IAsyncRepository<PlcInformation, int>
{
}
