using Infrastructure.Persistence.Abstract;
using MediatR;

namespace Application.Features.CalibrationMeasurements.Commands.Delete;

public class DeleteCalibrationMeasurementCommandHandler(ICalibrationMeasurementRepository repository)
    : IRequestHandler<DeleteCalibrationMeasurementCommand, bool>
{
    public async Task<bool> Handle(DeleteCalibrationMeasurementCommand request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        if (entity is null)
            return false;
        await repository.DeleteAsync(entity);
        return true;
    }
}
