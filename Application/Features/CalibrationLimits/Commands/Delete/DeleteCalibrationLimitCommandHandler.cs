using Infrastructure.Persistence.Abstract;
using MediatR;

namespace Application.Features.CalibrationLimits.Commands.Delete;

public class DeleteCalibrationLimitCommandHandler(ICalibrationLimitRepository repository)
    : IRequestHandler<DeleteCalibrationLimitCommand, bool>
{
    public async Task<bool> Handle(DeleteCalibrationLimitCommand request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        if (entity is null)
            return false;
        await repository.DeleteAsync(entity);
        return true;
    }
}
