using ISKI.Core.Domain;

namespace Domain.Entities;

public class UserMailAlarm : BaseEntity<int>
{
    public int UserId { get; set; }
    public int MailAlarmId { get; set; }
    public bool IsActive { get; set; }
}

