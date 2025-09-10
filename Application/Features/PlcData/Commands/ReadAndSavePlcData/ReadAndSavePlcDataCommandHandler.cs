using System;
using Application.Services.Parsing;
using Infrastructure.Persistence.Abstract;
using Infrastructure.Services.PLC;
using MediatR;
using AutoMapper;
using Application.Features.PlcData.Dtos;
using Application.Features.AnalogSensorDatas.Dtos;
using Application.Features.DigitalSensorDatas.Dtos;
using Microsoft.Extensions.Logging;

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
    IMapper mapper,
    IPlcDataCache plcDataCache,
    ILogger<ReadAndSavePlcDataCommandHandler> logger) : IRequestHandler<ReadAndSavePlcDataCommand, PlcDataDto>
{
    public async Task<PlcDataDto> Handle(ReadAndSavePlcDataCommand request, CancellationToken cancellationToken)
    {
        try
        {
            // Read analog bytes and persist
            byte[]? analogBytes = await plcClient.ReadBytesAsync(request.IpAddress, request.AnalogDbNumber, request.AnalogStart, request.AnalogLength);
            if (analogBytes == null)
            {
                throw new InvalidOperationException("Analog data could not be read from PLC");
            }
            var analogEntity = parser.ParseAnalog(analogBytes);
            analogEntity = await analogRepository.AddAsync(analogEntity);

            // Read digital bytes and persist
            byte[]? digitalBytes = await plcClient.ReadBytesAsync(request.IpAddress, request.DigitalDbNumber, request.DigitalStart, request.DigitalLength);
            if (digitalBytes == null)
            {
                throw new InvalidOperationException("Digital data could not be read from PLC");
            }
            var digitalEntity = parser.ParseDigital(digitalBytes);
            digitalEntity = await digitalRepository.AddAsync(digitalEntity);

            byte[]? timeParameterBytes = await plcClient.ReadBytesAsync(request.IpAddress, request.TimeParameterDbNumber, request.TimeParameterStart, request.TimeParameterLength);
            if (timeParameterBytes == null)
            {
                throw new InvalidOperationException("Time parameter data could not be read from PLC");
            }
            var timeParameterEntity = parser.ParseTimeParameter(timeParameterBytes);

            // Map to DTOs
            var analogDto = mapper.Map<AnalogSensorDataDto>(analogEntity);
            var digitalDto = mapper.Map<DigitalSensorDataDto>(digitalEntity);
            var timeParameterDto = mapper.Map<PlcTimeParametersDto>(timeParameterEntity);

            var dto = new PlcDataDto
            {
                Analog = analogDto,
                Digital = digitalDto,
                TimeParameter = timeParameterDto
            };

            plcDataCache.Update(dto);
            return dto;
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error reading or saving PLC data");
            throw;
        }
    }
}
