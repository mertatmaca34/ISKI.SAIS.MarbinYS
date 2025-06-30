namespace Application.Features.MailTriggerRecipients.Dtos;

public class MailTriggerRecipientDto
{
    public int Id { get; set; }
    public int MailTriggerId { get; set; }
    public int MailUserId { get; set; }
}
