using Application.Features.Stations.Dtos;
using AutoMapper;
using Infrastructure.Persistence.Abstract;
using MediatR;

namespace Application.Features.Stations.Queries.GetById;

public class GetStationByIdQueryHandler(
    IStationRepository repository,
    IMapper mapper) : IRequestHandler<GetStationByIdQuery, StationDto?>
{
    public async Task<StationDto?> Handle(GetStationByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        return entity is null ? null : mapper.Map<StationDto>(entity);
    }
}
