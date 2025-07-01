using Application.Features.AnalogSensorDatas.Dtos;
using AutoMapper;
using Domain.Entities;
using Infrastructure.Persistence.Abstract;
using MediatR;

namespace Application.Features.AnalogSensorDatas.Commands.Create;

public class CreateAnalogSensorDataCommandHandler(
    IAnalogSensorDataRepository repository,
    IMapper mapper) : IRequestHandler<CreateAnalogSensorDataCommand, AnalogSensorDataDto>
{
    public async Task<AnalogSensorDataDto> Handle(CreateAnalogSensorDataCommand request, CancellationToken cancellationToken)
    {
        var entity = mapper.Map<AnalogSensorData>(request);
        entity = await repository.AddAsync(entity);
        return mapper.Map<AnalogSensorDataDto>(entity);
    }
}
