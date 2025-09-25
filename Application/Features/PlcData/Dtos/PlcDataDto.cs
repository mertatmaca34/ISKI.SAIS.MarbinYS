using Application.Features.AnalogSensorDatas.Dtos;
using Application.Features.DigitalSensorDatas.Dtos;

namespace Application.Features.PlcData.Dtos;
/// <summary>
/// DTO that groups both analog and digital sensor data retrieved from the PLC.
/// </summary>
public class PlcDataDto
{
    public required AnalogSensorDataDto Analog { get; set; }
    public required DigitalSensorDataDto Digital { get; set; }
    public required PlcTimeParametersDto TimeParameter { get; set; }
    public AnalogSensorAverageDto AnalogHourlyAverage { get; set; } = new();
}
