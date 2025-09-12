using System.Threading;
using Application.Features.PlcData.Commands.ReadAndSavePlcData;
using Domain.Entities;

namespace Application.Services.PlcData;

public interface IPlcDataReader
{
    Task<Domain.Entities.PlcData> ReadAsync(ReadAndSavePlcDataCommand request, CancellationToken cancellationToken);
}
