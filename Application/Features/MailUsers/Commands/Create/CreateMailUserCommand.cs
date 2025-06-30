using Application.Features.MailUsers.Dtos;
using MediatR;

namespace Application.Features.MailUsers.Commands.Create;

public record CreateMailUserCommand(
    string FullName,
    string Email,
    string Role,
    bool IsActive
) : IRequest<MailUserDto>;
