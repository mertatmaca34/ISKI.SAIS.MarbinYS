using Application.Features.MailTriggerRecipients.Dtos;
using MediatR;

namespace Application.Features.MailTriggerRecipients.Commands.Create;

public record CreateMailTriggerRecipientCommand(int MailTriggerId, int MailUserId)
    : IRequest<MailTriggerRecipientDto>;
