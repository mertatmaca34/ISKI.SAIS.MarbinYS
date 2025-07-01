using MediatR;

namespace Application.Features.PlcData.Commands.ReadAndSavePlcData;

/// <summary>
/// Command to read sensor information from the PLC and persist it.
/// </summary>
public record ReadAndSavePlcDataCommand(
    string IpAddress,
    int AnalogDbNumber,
    int AnalogStart,
    int AnalogLength,
    int DigitalDbNumber,
    int DigitalStart,
    int DigitalLength) : IRequest;
