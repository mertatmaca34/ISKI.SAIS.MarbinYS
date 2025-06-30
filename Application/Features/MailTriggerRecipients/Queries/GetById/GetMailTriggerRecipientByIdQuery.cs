using Application.Features.MailTriggerRecipients.Dtos;
using MediatR;

namespace Application.Features.MailTriggerRecipients.Queries.GetById;

public record GetMailTriggerRecipientByIdQuery(int Id) : IRequest<MailTriggerRecipientDto?>;
