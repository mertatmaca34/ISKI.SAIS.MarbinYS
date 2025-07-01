using ISKI.Core.Domain;

namespace Domain.Entities;

public class AnalogSensorData : BaseEntity<int>
{
    public DateTime Readtime { get; set; }
    public double AkisHizi { get; set; }
    public double Akm { get; set; }
    public double CozunmusOksijen { get; set; }
    public double Debi { get; set; }
    public double? DesarjDebi { get; set; }
    public double? HariciDebi { get; set; }
    public double? HariciDebi2 { get; set; }
    public double Koi { get; set; }
    public double Ph { get; set; }
    public double Sicaklik { get; set; }
    public double Iletkenlik { get; set; }
}
