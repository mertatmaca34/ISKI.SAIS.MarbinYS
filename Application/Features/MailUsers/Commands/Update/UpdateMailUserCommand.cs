using Application.Features.MailUsers.Dtos;
using MediatR;

namespace Application.Features.MailUsers.Commands.Update;

public record UpdateMailUserCommand(
    int Id,
    string FullName,
    string Email,
    string Role,
    bool IsActive
) : IRequest<MailUserDto>;
