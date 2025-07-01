using Application.Features.AnalogSensorDatas.Dtos;
using AutoMapper;
using Infrastructure.Persistence.Abstract;
using MediatR;

namespace Application.Features.AnalogSensorDatas.Commands.Update;

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
