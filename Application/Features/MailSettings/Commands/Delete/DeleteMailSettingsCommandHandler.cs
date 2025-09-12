using Domain.Repositories;
using MediatR;

namespace Application.Features.MailSettings.Commands.Delete;

public class DeleteMailSettingsCommandHandler(IMailSettingsRepository repository)
    : IRequestHandler<DeleteMailSettingsCommand, bool>
{
    public async Task<bool> Handle(DeleteMailSettingsCommand request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        if (entity is null)
            return false;

        await repository.DeleteAsync(entity);
        return true;
    }
}
