using System.Threading;
using Application.Features.PlcData.Commands.ReadAndSavePlcData;
using Domain.Entities;

namespace Application.Services.PlcData;

public interface IPlcDataReader
{
    Task<PlcData> ReadAsync(ReadAndSavePlcDataCommand request, CancellationToken cancellationToken);
}
