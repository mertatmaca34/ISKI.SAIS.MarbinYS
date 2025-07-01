using Application.Services.Repositories;
using MediatR;

namespace Application.Features.DigitalSensorData.Commands.Delete;

public class DeleteDigitalSensorDataCommandHandler(IDigitalSensorDataRepository repository)
    : IRequestHandler<DeleteDigitalSensorDataCommand, bool>
{
    public async Task<bool> Handle(DeleteDigitalSensorDataCommand request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        if (entity is null)
            return false;
        await repository.DeleteAsync(entity);
        return true;
    }
}
