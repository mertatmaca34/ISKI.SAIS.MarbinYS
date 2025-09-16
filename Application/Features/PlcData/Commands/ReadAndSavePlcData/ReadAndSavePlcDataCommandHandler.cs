using System;
using System.Collections.Generic;
using Application.Constants;
using Application.Services.PlcData;
using Infrastructure.Persistence;
using MediatR;
using AutoMapper;
using Application.Features.PlcData.Dtos;
using Application.Features.SendDatas.Commands;
using Microsoft.Extensions.Logging;
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
    IMediator mediator,
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

            var analog = plcData.Analog;
            var measurements = new Dictionary<string, double>
            {
                [nameof(analog.AkisHizi)] = analog.AkisHizi,
                [nameof(analog.Akm)] = analog.Akm,
                [nameof(analog.CozunmusOksijen)] = analog.CozunmusOksijen,
                [nameof(analog.Debi)] = analog.Debi,
                [nameof(analog.DesarjDebi)] = analog.DesarjDebi ?? 0,
                [nameof(analog.HariciDebi)] = analog.HariciDebi ?? 0,
                [nameof(analog.HariciDebi2)] = analog.HariciDebi2 ?? 0,
                [nameof(analog.Koi)] = analog.Koi,
                [nameof(analog.Ph)] = analog.Ph,
                [nameof(analog.Sicaklik)] = analog.Sicaklik,
                [nameof(analog.Iletkenlik)] = analog.Iletkenlik
            };

            foreach (var kvp in measurements)
            {
                await mediator.Send(new SendDataCommand(kvp.Key, kvp.Value), cancellationToken);
            }

            return mapper.Map<PlcDataDto>(plcData);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, LogMessages.PlcData.ReadOrSaveError);
            throw;
        }
    }
}
