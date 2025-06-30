using Application.Features.MailSettings.Dtos;
using MediatR;

namespace Application.Features.MailSettings.Commands.Create;

public record CreateMailSettingsCommand(
    string SmtpHost,
    int SmtpPort,
    string SmtpUser,
    string SmtpPassword,
    bool UseSsl,
    string SenderEmail,
    string SenderName
) : IRequest<MailSettingsDto>;
