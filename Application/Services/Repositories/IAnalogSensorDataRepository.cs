using Domain.Entities;
using ISKI.Core.Infrastructure;

namespace Application.Services.Repositories;

public interface IAnalogSensorDataRepository : IAsyncRepository<AnalogSensorData, int>
{
}
