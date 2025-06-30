using MediatR;

namespace Application.Features.MailUsers.Commands.Delete;

public record DeleteMailUserCommand(int Id) : IRequest<bool>;
