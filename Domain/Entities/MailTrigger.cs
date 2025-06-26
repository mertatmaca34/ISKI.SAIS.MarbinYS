using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class MailTrigger
{
    public int Id { get; set; }
    public string Name { get; set; }                  // "Yüksek AKM"
    public string SensorTag { get; set; }             // "AKM"
    public ComparisonOperator Operator { get; set; }  // >
    public double Threshold { get; set; }             // 50
    public int CooldownMinutes { get; set; }          // 30
    public bool IsActive { get; set; }
    public DateTime? LastMailSentAt { get; set; }

    public ICollection<MailTriggerRecipient> Recipients { get; set; }
}