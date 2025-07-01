using Application.Features.CalibrationMeasurements.Dtos;
using AutoMapper;
using Domain.Entities;
using Infrastructure.Persistence.Abstract;
using MediatR;

namespace Application.Features.CalibrationMeasurements.Commands.Create;

public class CreateCalibrationMeasurementCommandHandler(
    ICalibrationMeasurementRepository repository,
    IMapper mapper) : IRequestHandler<CreateCalibrationMeasurementCommand, CalibrationMeasurementDto>
{
    public async Task<CalibrationMeasurementDto> Handle(CreateCalibrationMeasurementCommand request, CancellationToken cancellationToken)
    {
        var entity = mapper.Map<CalibrationMeasurement>(request);
        entity = await repository.AddAsync(entity);
        return mapper.Map<CalibrationMeasurementDto>(entity);
    }
}
