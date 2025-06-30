using MediatR;
using Application.Features.MailUsers.Dtos;

namespace Application.Features.MailUsers.Queries.GetList;

public record GetMailUsersQuery() : IRequest<List<MailUserDto>>;
