using ISKI.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class MailSettings : BaseEntity<int>
{
    public string SmtpHost { get; set; }
    public int SmtpPort { get; set; }
    public string SmtpUser { get; set; }
    public string SmtpPassword { get; set; }
    public bool UseSsl { get; set; }
    public string SenderEmail { get; set; }
    public string SenderName { get; set; }
    public bool UseDefaultCredentials { get; set; }
}
