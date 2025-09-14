using Application.Features.Users.Dtos;
using MediatR;

namespace Application.Features.Users.Commands.Update;

public record UpdateUserCommand(
    int Id,
    string UserName,
    string Email,
    string Password
) : IRequest<UserDto>;

