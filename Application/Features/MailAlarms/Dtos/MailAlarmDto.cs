namespace Application.Features.MailAlarms.Dtos;

public class MailAlarmDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public double Limit { get; set; }
    public bool IsActive { get; set; }
}

