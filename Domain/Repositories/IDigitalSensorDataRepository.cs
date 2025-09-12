using Domain.Entities;
using ISKI.Core.Infrastructure;

namespace Domain.Repositories;

public interface IDigitalSensorDataRepository : IAsyncRepository<DigitalSensorData, int>
{
}
