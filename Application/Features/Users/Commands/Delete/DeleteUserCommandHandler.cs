using Domain.Repositories;
using MediatR;

namespace Application.Features.Users.Commands.Delete;

public class DeleteUserCommandHandler(IUserRepository repository)
    : IRequestHandler<DeleteUserCommand, bool>
{
    public async Task<bool> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        if (entity is null)
            return false;
        await repository.DeleteAsync(entity);
        return true;
    }
}

