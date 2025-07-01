using MediatR;
using Infrastructure.Persistence.Abstract;

namespace Application.Features.MailTriggers.Commands.Delete;

public class DeleteMailTriggerCommandHandler(IMailTriggerRepository repository)
    : IRequestHandler<DeleteMailTriggerCommand, bool>
{
    public async Task<bool> Handle(DeleteMailTriggerCommand request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        if (entity is null)
            return false;

        await repository.DeleteAsync(entity);
        return true;
    }
}
