using ISKI.Core.Domain;

namespace Domain.Entities;

public class MailAlarm : BaseEntity<int>
{
    public string Name { get; set; } = string.Empty;
    public string Channel { get; set; } = string.Empty;
    public double Limit { get; set; }
    public string MailSubject { get; set; } = string.Empty;
    public string MailBody { get; set; } = string.Empty;
}

