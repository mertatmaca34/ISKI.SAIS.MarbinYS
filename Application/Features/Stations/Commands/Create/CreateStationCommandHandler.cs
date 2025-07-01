using Application.Features.Stations.Dtos;
using AutoMapper;
using Domain.Entities;
using Infrastructure.Persistence.Abstract;
using MediatR;

namespace Application.Features.Stations.Commands.Create;

public class CreateStationCommandHandler(
    IStationRepository repository,
    IMapper mapper) : IRequestHandler<CreateStationCommand, StationDto>
{
    public async Task<StationDto> Handle(CreateStationCommand request, CancellationToken cancellationToken)
    {
        var entity = mapper.Map<Station>(request);
        entity = await repository.AddAsync(entity);
        return mapper.Map<StationDto>(entity);
    }
}
