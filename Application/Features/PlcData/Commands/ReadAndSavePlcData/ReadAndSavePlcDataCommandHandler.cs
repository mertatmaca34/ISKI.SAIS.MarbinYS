using System;
using Application.Services.PlcData;
using Infrastructure.Persistence;
using MediatR;
using AutoMapper;
using Application.Features.PlcData.Dtos;
using Microsoft.Extensions.Logging;
using Domain.Entities;
using Infrastructure.Services.PLC;

namespace Application.Features.PlcData.Commands.ReadAndSavePlcData;

/// <summary>
/// Handler that reads sensor data from the PLC and persists the parsed entities
/// in a single database transaction.
/// </summary>
public class ReadAndSavePlcDataCommandHandler(
    IPlcDataReader plcDataReader,
    IBKSContext context,
    IMapper mapper,
    IPlcDataCache plcDataCache,
    ILogger<ReadAndSavePlcDataCommandHandler> logger) : IRequestHandler<ReadAndSavePlcDataCommand, PlcDataDto>
{
    public async Task<PlcDataDto> Handle(ReadAndSavePlcDataCommand request, CancellationToken cancellationToken)
    {
        try
        {
            Domain.Entities.PlcData plcData = await plcDataReader.ReadAsync(request, cancellationToken);

            context.AnalogSensorData.Add(plcData.Analog);
            context.DigitalSensorData.Add(plcData.Digital);
            await context.SaveChangesAsync(cancellationToken);

            plcDataCache.Update(plcData);
            return mapper.Map<PlcDataDto>(plcData);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error reading or saving PLC data");
            throw;
        }
    }
}
