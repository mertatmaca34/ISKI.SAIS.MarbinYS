using Domain.Repositories;
using MediatR;

namespace Application.Features.Stations.Commands.Delete;

public class DeleteStationCommandHandler(IStationRepository repository) : IRequestHandler<DeleteStationCommand, bool>
{
    public async Task<bool> Handle(DeleteStationCommand request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        if (entity is null)
            return false;
        await repository.DeleteAsync(entity);
        return true;
    }
}
