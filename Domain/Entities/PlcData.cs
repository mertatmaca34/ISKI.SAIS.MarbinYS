namespace Domain.Entities;

public class PlcData
{
    public required AnalogSensorData Analog { get; set; }
    public required DigitalSensorData Digital { get; set; }
    public required PlcTimeParameters TimeParameter { get; set; }
}

