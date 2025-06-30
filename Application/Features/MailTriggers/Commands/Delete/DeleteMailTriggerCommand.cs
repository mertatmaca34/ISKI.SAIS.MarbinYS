using MediatR;

namespace Application.Features.MailTriggers.Commands.Delete;

public record DeleteMailTriggerCommand(int Id) : IRequest<bool>;
