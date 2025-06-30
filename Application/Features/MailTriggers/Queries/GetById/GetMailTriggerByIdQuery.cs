using MediatR;
using Application.Features.MailTriggers.Dtos;

namespace Application.Features.MailTriggers.Queries.GetById;

public record GetMailTriggerByIdQuery(int Id) : IRequest<MailTriggerDto?>;
