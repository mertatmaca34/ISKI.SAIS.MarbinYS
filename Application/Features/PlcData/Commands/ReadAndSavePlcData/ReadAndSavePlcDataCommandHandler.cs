using Application.Services.Parsing;
using Application.Services.Repositories;
using Infrastructure.Services.PLC;
using MediatR;

namespace Application.Features.PlcData.Commands.ReadAndSavePlcData;

/// <summary>
/// Handler that reads both analog and digital sensor data from the PLC and
/// saves the parsed entities using the repositories.
/// </summary>
public class ReadAndSavePlcDataCommandHandler(
    IPlcClient plcClient,
    IPlcDataParser parser,
    IAnalogSensorDataRepository analogRepository,
    IDigitalSensorDataRepository digitalRepository) : IRequestHandler<ReadAndSavePlcDataCommand>
{
    public async Task Handle(ReadAndSavePlcDataCommand request, CancellationToken cancellationToken)
    {
        // Read analog bytes and persist
        byte[] analogBytes = await plcClient.ReadBytesAsync(request.IpAddress, request.AnalogDbNumber, request.AnalogStart, request.AnalogLength);
        var analogEntity = parser.ParseAnalog(analogBytes);
        await analogRepository.AddAsync(analogEntity);

        // Read digital bytes and persist
        byte[] digitalBytes = await plcClient.ReadBytesAsync(request.IpAddress, request.DigitalDbNumber, request.DigitalStart, request.DigitalLength);
        var digitalEntity = parser.ParseDigital(digitalBytes);
        await digitalRepository.AddAsync(digitalEntity);
    }
}
