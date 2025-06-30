using Application.Services.Repositories;
using MediatR;

namespace Application.Features.MailTriggerRecipients.Commands.Delete;

public class DeleteMailTriggerRecipientCommandHandler(IMailTriggerRecipientRepository repository)
    : IRequestHandler<DeleteMailTriggerRecipientCommand, bool>
{
    public async Task<bool> Handle(DeleteMailTriggerRecipientCommand request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        if (entity is null)
            return false;
        await repository.DeleteAsync(entity);
        return true;
    }
}
