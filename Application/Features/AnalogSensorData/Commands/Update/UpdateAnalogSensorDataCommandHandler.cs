using Application.Features.AnalogSensorData.Dtos;
using Application.Services.Repositories;
using AutoMapper;
using MediatR;

namespace Application.Features.AnalogSensorData.Commands.Update;

public class UpdateAnalogSensorDataCommandHandler(
    IAnalogSensorDataRepository repository,
    IMapper mapper) : IRequestHandler<UpdateAnalogSensorDataCommand, AnalogSensorDataDto>
{
    public async Task<AnalogSensorDataDto> Handle(UpdateAnalogSensorDataCommand request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        if (entity is null)
            throw new KeyNotFoundException($"AnalogSensorData {request.Id} not found");
        mapper.Map(request, entity);
        entity = await repository.UpdateAsync(entity);
        return mapper.Map<AnalogSensorDataDto>(entity);
    }
}
