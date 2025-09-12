using Application.Features.CalibrationLimits.Dtos;
using AutoMapper;
using Domain.Repositories;
using MediatR;

namespace Application.Features.CalibrationLimits.Queries.GetById;

public class GetCalibrationLimitByIdQueryHandler(
    ICalibrationLimitRepository repository,
    IMapper mapper) : IRequestHandler<GetCalibrationLimitByIdQuery, CalibrationLimitDto?>
{
    public async Task<CalibrationLimitDto?> Handle(GetCalibrationLimitByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        return entity is null ? null : mapper.Map<CalibrationLimitDto>(entity);
    }
}
