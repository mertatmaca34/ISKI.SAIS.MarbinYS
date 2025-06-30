using Application.Features.MailUsers.Dtos;
using MediatR;

namespace Application.Features.MailUsers.Queries.GetById;

public record GetMailUserByIdQuery(int Id) : IRequest<MailUserDto?>;
