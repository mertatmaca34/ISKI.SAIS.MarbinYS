using Application.Features.CalibrationLimits.Dtos;
using AutoMapper;
using Domain.Repositories;
using MediatR;

namespace Application.Features.CalibrationLimits.Commands.Update;

public class UpdateCalibrationLimitCommandHandler(
    ICalibrationLimitRepository repository,
    IMapper mapper) : IRequestHandler<UpdateCalibrationLimitCommand, CalibrationLimitDto>
{
    public async Task<CalibrationLimitDto> Handle(UpdateCalibrationLimitCommand request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        if (entity is null)
            throw new KeyNotFoundException($"CalibrationLimit {request.Id} not found");
        mapper.Map(request, entity);
        entity = await repository.UpdateAsync(entity);
        return mapper.Map<CalibrationLimitDto>(entity);
    }
}
