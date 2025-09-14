namespace WinUI.Models;

public class MailSettingsDto
{
    public int Id { get; set; }
    public string SmtpHost { get; set; }
    public int SmtpPort { get; set; }
    public string SmtpUser { get; set; }
    public string SmtpPassword { get; set; }
    public bool UseSsl { get; set; }
    public string SenderEmail { get; set; }
    public string SenderName { get; set; }
    public bool UseDefaultCredentials { get; set; }
}

