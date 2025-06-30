using Application.Services.Repositories;
using MediatR;

namespace Application.Features.MailUsers.Commands.Delete;

public class DeleteMailUserCommandHandler(IMailUserRepository repository)
    : IRequestHandler<DeleteMailUserCommand, bool>
{
    public async Task<bool> Handle(DeleteMailUserCommand request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        if (entity is null)
            return false;

        await repository.DeleteAsync(entity);
        return true;
    }
}
