namespace Application.Features.MailLogs.Dtos;

public class MailLogDto
{
    public int Id { get; set; }
    public int MailTriggerId { get; set; }
    public string RecipientEmail { get; set; }
    public DateTime SentAt { get; set; }
    public bool IsSuccess { get; set; }
    public string ErrorMessage { get; set; }
    public string BodySnapshot { get; set; }
}
