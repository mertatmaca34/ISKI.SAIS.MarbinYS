using Domain.Enums;
using ISKI.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class MailTrigger : BaseEntity<int>
{
    public string Name { get; set; }
    public string SensorTag { get; set; }
    public ComparisonOperator Operator { get; set; }
    public double Threshold { get; set; }
    public int CooldownMinutes { get; set; }
    public bool IsActive { get; set; }
    public DateTime? LastMailSentAt { get; set; }
    public ICollection<MailTriggerRecipient> Recipients { get; set; }
}
