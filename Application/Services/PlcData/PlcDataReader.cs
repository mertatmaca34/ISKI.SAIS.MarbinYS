using System;
using System.Threading;
using Application.Features.PlcData.Commands.ReadAndSavePlcData;
using Application.Services.Parsing;
using Domain.Entities;
using Infrastructure.Services.PLC;

namespace Application.Services.PlcData;

public class PlcDataReader(IPlcClient plcClient, IPlcDataParser parser) : IPlcDataReader
{
    private readonly IPlcClient _plcClient = plcClient;
    private readonly IPlcDataParser _parser = parser;

    public async Task<PlcData> ReadAsync(ReadAndSavePlcDataCommand request, CancellationToken cancellationToken)
    {
        var analogTask = _plcClient.ReadBytesAsync(request.IpAddress, request.AnalogDbNumber, request.AnalogStart, request.AnalogLength);
        var digitalTask = _plcClient.ReadBytesAsync(request.IpAddress, request.DigitalDbNumber, request.DigitalStart, request.DigitalLength);
        var timeTask = _plcClient.ReadBytesAsync(request.IpAddress, request.TimeParameterDbNumber, request.TimeParameterStart, request.TimeParameterLength);

        await Task.WhenAll(analogTask, digitalTask, timeTask);

        byte[] analogBytes = await analogTask ?? throw new InvalidOperationException("Analog data could not be read from PLC");
        byte[] digitalBytes = await digitalTask ?? throw new InvalidOperationException("Digital data could not be read from PLC");
        byte[] timeBytes = await timeTask ?? throw new InvalidOperationException("Time parameter data could not be read from PLC");

        var analogEntity = _parser.ParseAnalog(analogBytes);
        var digitalEntity = _parser.ParseDigital(digitalBytes);
        var timeEntity = _parser.ParseTimeParameter(timeBytes);

        return new PlcData
        {
            Analog = analogEntity,
            Digital = digitalEntity,
            TimeParameter = timeEntity
        };
    }
}
