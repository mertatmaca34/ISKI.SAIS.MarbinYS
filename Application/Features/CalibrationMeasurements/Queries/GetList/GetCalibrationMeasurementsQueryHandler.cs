using Application.Features.CalibrationMeasurements.Dtos;
using AutoMapper;
using Infrastructure.Persistence.Abstract;
using MediatR;

namespace Application.Features.CalibrationMeasurements.Queries.GetList;

public class GetCalibrationMeasurementsQueryHandler(
    ICalibrationMeasurementRepository repository,
    IMapper mapper) : IRequestHandler<GetCalibrationMeasurementsQuery, List<CalibrationMeasurementDto>>
{
    public async Task<List<CalibrationMeasurementDto>> Handle(GetCalibrationMeasurementsQuery request, CancellationToken cancellationToken)
    {
        var items = await repository.GetAllAsync(x => true);
        return items.Select(mapper.Map<CalibrationMeasurementDto>).ToList();
    }
}
