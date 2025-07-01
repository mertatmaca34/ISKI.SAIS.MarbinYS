using Application.Features.DigitalSensorData.Dtos;
using Application.Services.Repositories;
using AutoMapper;
using MediatR;

namespace Application.Features.DigitalSensorData.Commands.Update;

public class UpdateDigitalSensorDataCommandHandler(
    IDigitalSensorDataRepository repository,
    IMapper mapper) : IRequestHandler<UpdateDigitalSensorDataCommand, DigitalSensorDataDto>
{
    public async Task<DigitalSensorDataDto> Handle(UpdateDigitalSensorDataCommand request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        if (entity is null)
            throw new KeyNotFoundException($"DigitalSensorData {request.Id} not found");
        mapper.Map(request, entity);
        entity = await repository.UpdateAsync(entity);
        return mapper.Map<DigitalSensorDataDto>(entity);
    }
}
