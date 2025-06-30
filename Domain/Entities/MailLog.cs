using ISKI.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class MailLog : BaseEntity<int>
{
    public int MailTriggerId { get; set; }
    public MailTrigger MailTrigger { get; set; }

    public string RecipientEmail { get; set; }
    public DateTime SentAt { get; set; }
    public bool IsSuccess { get; set; }
    public string ErrorMessage { get; set; }
    public string BodySnapshot { get; set; }
}
