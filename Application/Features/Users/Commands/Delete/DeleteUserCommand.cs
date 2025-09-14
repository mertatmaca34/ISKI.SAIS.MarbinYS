using MediatR;

namespace Application.Features.Users.Commands.Delete;

public record DeleteUserCommand(int Id) : IRequest<bool>;

