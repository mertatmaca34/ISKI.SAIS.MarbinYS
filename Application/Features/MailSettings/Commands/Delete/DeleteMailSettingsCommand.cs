using MediatR;

namespace Application.Features.MailSettings.Commands.Delete;

public record DeleteMailSettingsCommand(int Id) : IRequest<bool>;
