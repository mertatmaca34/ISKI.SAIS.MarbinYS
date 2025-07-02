using Application.Services.Parsing;
using Infrastructure.Persistence.Abstract;
using Infrastructure.Services.PLC;
using MediatR;
using AutoMapper;
using Application.Features.PlcData.Dtos;
using Application.Features.AnalogSensorDatas.Dtos;
using Application.Features.DigitalSensorDatas.Dtos;

namespace Application.Features.PlcData.Commands.ReadAndSavePlcData;

/// <summary>
/// Handler that reads both analog and digital sensor data from the PLC and
/// saves the parsed entities using the repositories.
/// </summary>
public class ReadAndSavePlcDataCommandHandler(
    IPlcClient plcClient,
    IPlcDataParser parser,
    IAnalogSensorDataRepository analogRepository,
    IDigitalSensorDataRepository digitalRepository,
    IMapper mapper) : IRequestHandler<ReadAndSavePlcDataCommand, PlcDataDto>
{
    public async Task<PlcDataDto> Handle(ReadAndSavePlcDataCommand request, CancellationToken cancellationToken)
    {
        // Read analog bytes and persist
        byte[] analogBytes = await plcClient.ReadBytesAsync(request.IpAddress, request.AnalogDbNumber, request.AnalogStart, request.AnalogLength);
        var analogEntity = parser.ParseAnalog(analogBytes);
        analogEntity = await analogRepository.AddAsync(analogEntity);

        // Read digital bytes and persist
        byte[] digitalBytes = await plcClient.ReadBytesAsync(request.IpAddress, request.DigitalDbNumber, request.DigitalStart, request.DigitalLength);
        var digitalEntity = parser.ParseDigital(digitalBytes);
        digitalEntity = await digitalRepository.AddAsync(digitalEntity);

        // Map to DTOs and return
        var analogDto = mapper.Map<AnalogSensorDataDto>(analogEntity);
        var digitalDto = mapper.Map<DigitalSensorDataDto>(digitalEntity);

        return new PlcDataDto
        {
            Analog = analogDto,
            Digital = digitalDto
        };
    }
}
