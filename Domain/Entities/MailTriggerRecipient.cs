using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class MailTriggerRecipient
{
    public int Id { get; set; }

    public int MailTriggerId { get; set; }
    public MailTrigger MailTrigger { get; set; }

    public int MailUserId { get; set; }
    public MailUser MailUser { get; set; }
}
