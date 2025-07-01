using Application.Features.CalibrationMeasurements.Dtos;
using Application.Services.Repositories;
using AutoMapper;
using MediatR;

namespace Application.Features.CalibrationMeasurements.Queries.GetById;

public class GetCalibrationMeasurementByIdQueryHandler(
    ICalibrationMeasurementRepository repository,
    IMapper mapper) : IRequestHandler<GetCalibrationMeasurementByIdQuery, CalibrationMeasurementDto?>
{
    public async Task<CalibrationMeasurementDto?> Handle(GetCalibrationMeasurementByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        return entity is null ? null : mapper.Map<CalibrationMeasurementDto>(entity);
    }
}
