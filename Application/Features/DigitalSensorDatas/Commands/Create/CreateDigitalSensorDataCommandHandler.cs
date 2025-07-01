using Application.Features.DigitalSensorDatas.Dtos;
using AutoMapper;
using Domain.Entities;
using Infrastructure.Persistence.Abstract;
using MediatR;

namespace Application.Features.DigitalSensorDatas.Commands.Create;

public class CreateDigitalSensorDataCommandHandler(
    IDigitalSensorDataRepository repository,
    IMapper mapper) : IRequestHandler<CreateDigitalSensorDataCommand, DigitalSensorDataDto>
{
    public async Task<DigitalSensorDataDto> Handle(CreateDigitalSensorDataCommand request, CancellationToken cancellationToken)
    {
        var entity = mapper.Map<DigitalSensorData>(request);
        entity = await repository.AddAsync(entity);
        return mapper.Map<DigitalSensorDataDto>(entity);
    }
}
