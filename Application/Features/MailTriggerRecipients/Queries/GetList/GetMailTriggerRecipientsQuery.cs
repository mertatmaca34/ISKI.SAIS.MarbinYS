using Application.Features.MailTriggerRecipients.Dtos;
using MediatR;

namespace Application.Features.MailTriggerRecipients.Queries.GetList;

public record GetMailTriggerRecipientsQuery() : IRequest<List<MailTriggerRecipientDto>>;
