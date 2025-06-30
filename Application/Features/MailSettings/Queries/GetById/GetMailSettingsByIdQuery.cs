using Application.Features.MailSettings.Dtos;
using MediatR;

namespace Application.Features.MailSettings.Queries.GetById;

public record GetMailSettingsByIdQuery(int Id) : IRequest<MailSettingsDto?>;
