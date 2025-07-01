using Infrastructure.Persistence.Abstract;
using MediatR;

namespace Application.Features.Plcs.Commands.Delete;

public class DeletePlcCommandHandler(IPlcRepository repository) : IRequestHandler<DeletePlcCommand, bool>
{
    public async Task<bool> Handle(DeletePlcCommand request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        if (entity is null)
            return false;
        await repository.DeleteAsync(entity);
        return true;
    }
}
