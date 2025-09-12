using Application.Features.CalibrationLimits.Dtos;
using AutoMapper;
using Domain.Repositories;
using MediatR;

namespace Application.Features.CalibrationLimits.Queries.GetList;

public class GetCalibrationLimitsQueryHandler(
    ICalibrationLimitRepository repository,
    IMapper mapper) : IRequestHandler<GetCalibrationLimitsQuery, List<CalibrationLimitDto>>
{
    public async Task<List<CalibrationLimitDto>> Handle(GetCalibrationLimitsQuery request, CancellationToken cancellationToken)
    {
        var items = await repository.GetAllAsync(x => true);
        return items.Select(mapper.Map<CalibrationLimitDto>).ToList();
    }
}
