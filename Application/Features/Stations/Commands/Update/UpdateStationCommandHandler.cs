using Application.Features.Stations.Dtos;
using Application.Services.Repositories;
using AutoMapper;
using MediatR;

namespace Application.Features.Stations.Commands.Update;

public class UpdateStationCommandHandler(
    IStationRepository repository,
    IMapper mapper) : IRequestHandler<UpdateStationCommand, StationDto>
{
    public async Task<StationDto> Handle(UpdateStationCommand request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        if (entity is null)
            throw new KeyNotFoundException($"Station {request.Id} not found");
        mapper.Map(request, entity);
        entity = await repository.UpdateAsync(entity);
        return mapper.Map<StationDto>(entity);
    }
}
