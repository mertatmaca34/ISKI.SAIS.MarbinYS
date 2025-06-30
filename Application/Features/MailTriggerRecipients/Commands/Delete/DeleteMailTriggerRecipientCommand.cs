using MediatR;

namespace Application.Features.MailTriggerRecipients.Commands.Delete;

public record DeleteMailTriggerRecipientCommand(int Id) : IRequest<bool>;
