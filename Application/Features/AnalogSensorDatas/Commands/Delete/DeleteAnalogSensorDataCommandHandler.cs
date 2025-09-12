using Domain.Repositories;
using MediatR;

namespace Application.Features.AnalogSensorDatas.Commands.Delete;

public class DeleteAnalogSensorDataCommandHandler(IAnalogSensorDataRepository repository)
    : IRequestHandler<DeleteAnalogSensorDataCommand, bool>
{
    public async Task<bool> Handle(DeleteAnalogSensorDataCommand request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        if (entity is null)
            return false;
        await repository.DeleteAsync(entity);
        return true;
    }
}
