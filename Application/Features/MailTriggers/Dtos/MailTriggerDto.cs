namespace Application.Features.MailTriggers.Dtos;

public class MailTriggerDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string SensorTag { get; set; } = string.Empty;
    public int Operator { get; set; }
    public double Threshold { get; set; }
    public int CooldownMinutes { get; set; }
    public bool IsActive { get; set; }
}
