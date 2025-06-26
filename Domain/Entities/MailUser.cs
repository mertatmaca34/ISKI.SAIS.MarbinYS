using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class MailUser
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }        // Optional: Admin, Operatör, vs.
    public bool IsActive { get; set; }

    public ICollection<MailTriggerRecipient> TriggerSubscriptions { get; set; }
}
