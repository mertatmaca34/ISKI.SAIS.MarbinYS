using Domain.Entities;
using ISKI.Core.Infrastructure;

namespace Domain.Repositories;

public interface IAnalogSensorDataRepository : IAsyncRepository<AnalogSensorData, int>
{
}
