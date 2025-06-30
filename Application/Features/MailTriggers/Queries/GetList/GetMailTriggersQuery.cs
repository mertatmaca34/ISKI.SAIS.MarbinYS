using MediatR;
using Application.Features.MailTriggers.Dtos;
using System.Collections.Generic;

namespace Application.Features.MailTriggers.Queries.GetList;

public record GetMailTriggersQuery() : IRequest<List<MailTriggerDto>>;
