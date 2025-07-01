using Infrastructure.Persistence.Abstract;
using MediatR;

namespace Application.Features.PlcInformations.Commands.Delete;

public class DeletePlcInformationCommandHandler(IPlcInformationRepository repository) : IRequestHandler<DeletePlcInformationCommand, bool>
{
    public async Task<bool> Handle(DeletePlcInformationCommand request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        if (entity is null)
            return false;
        await repository.DeleteAsync(entity);
        return true;
    }
}
