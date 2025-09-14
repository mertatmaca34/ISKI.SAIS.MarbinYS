using Application.Features.Users.Dtos;
using MediatR;

namespace Application.Features.Users.Commands.Create;

public record CreateUserCommand(
    string UserName,
    string Email,
    string Password
) : IRequest<UserDto>;

