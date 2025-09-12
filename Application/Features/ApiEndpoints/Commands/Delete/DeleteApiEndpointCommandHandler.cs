using Domain.Repositories;
using MediatR;

namespace Application.Features.ApiEndpoints.Commands.Delete;

public class DeleteApiEndpointCommandHandler(IApiEndpointRepository repository)
    : IRequestHandler<DeleteApiEndpointCommand, bool>
{
    public async Task<bool> Handle(DeleteApiEndpointCommand request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        if (entity is null)
            return false;
        await repository.DeleteAsync(entity);
        return true;
    }
}
