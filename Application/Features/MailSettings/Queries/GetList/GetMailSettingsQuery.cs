using MediatR;
using Application.Features.MailSettings.Dtos;

namespace Application.Features.MailSettings.Queries.GetList;

public record GetMailSettingsQuery() : IRequest<List<MailSettingsDto>>;
