namespace WinUI.Models;

public class PlcDataDto
{
    public required AnalogSensorDataDto Analog { get; set; }
    public required DigitalSensorDataDto Digital { get; set; }
}
