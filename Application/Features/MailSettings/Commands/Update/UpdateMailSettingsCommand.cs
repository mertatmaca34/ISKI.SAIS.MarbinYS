using Application.Features.MailSettings.Dtos;
using MediatR;

namespace Application.Features.MailSettings.Commands.Update;

public record UpdateMailSettingsCommand(
    int Id,
    string SmtpHost,
    int SmtpPort,
    string SmtpUser,
    string SmtpPassword,
    bool UseSsl,
    string SenderEmail,
    string SenderName
) : IRequest<MailSettingsDto>;
