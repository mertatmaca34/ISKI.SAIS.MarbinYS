using Domain.Enums;

namespace Application.Features.MailAlarms.Dtos;

public class MailAlarmDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Channel { get; set; } = string.Empty;
    public double Limit { get; set; }
    public string MailSubject { get; set; } = string.Empty;
    public string MailBody { get; set; } = string.Empty;
    public bool IsActive { get; set; }
    public MailTemplateType TemplateType { get; set; }
}

