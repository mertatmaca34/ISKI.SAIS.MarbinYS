using Domain.Entities;
using ISKI.Core.Infrastructure;

namespace Domain.Repositories;

public interface IStationRepository : IAsyncRepository<Station, int>
{
}
