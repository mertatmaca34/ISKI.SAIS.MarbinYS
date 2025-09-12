using Application.Features.CalibrationMeasurements.Dtos;
using AutoMapper;
using Domain.Repositories;
using MediatR;

namespace Application.Features.CalibrationMeasurements.Commands.Update;

public class UpdateCalibrationMeasurementCommandHandler(
    ICalibrationMeasurementRepository repository,
    IMapper mapper) : IRequestHandler<UpdateCalibrationMeasurementCommand, CalibrationMeasurementDto>
{
    public async Task<CalibrationMeasurementDto> Handle(UpdateCalibrationMeasurementCommand request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        if (entity is null)
            throw new KeyNotFoundException($"CalibrationMeasurement {request.Id} not found");
        mapper.Map(request, entity);
        entity = await repository.UpdateAsync(entity);
        return mapper.Map<CalibrationMeasurementDto>(entity);
    }
}
