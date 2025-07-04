using Application.Features.PlcData.Dtos;
using Domain.Entities;

namespace Application.Services.Parsing;

/// <summary>
/// Parses byte arrays read from the PLC into domain entities.
/// </summary>
public interface IPlcDataParser
{
    AnalogSensorData ParseAnalog(byte[] data);
    DigitalSensorData ParseDigital(byte[] data);
    PlcTimeParametersDto ParseTimeParameter(byte[] data);
}
