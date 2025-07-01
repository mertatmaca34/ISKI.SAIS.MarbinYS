using Application.Features.DigitalSensorData.Dtos;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.DigitalSensorData.Commands.Create;

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
