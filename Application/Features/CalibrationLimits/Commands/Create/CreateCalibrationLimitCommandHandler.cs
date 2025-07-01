using Application.Features.CalibrationLimits.Dtos;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.CalibrationLimits.Commands.Create;

public class CreateCalibrationLimitCommandHandler(
    ICalibrationLimitRepository repository,
    IMapper mapper) : IRequestHandler<CreateCalibrationLimitCommand, CalibrationLimitDto>
{
    public async Task<CalibrationLimitDto> Handle(CreateCalibrationLimitCommand request, CancellationToken cancellationToken)
    {
        var entity = mapper.Map<CalibrationLimit>(request);
        entity = await repository.AddAsync(entity);
        return mapper.Map<CalibrationLimitDto>(entity);
    }
}
