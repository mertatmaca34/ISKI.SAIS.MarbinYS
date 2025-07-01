using Application.Features.Stations.Dtos;
using Application.Services.Repositories;
using AutoMapper;
using MediatR;

namespace Application.Features.Stations.Queries.GetList;

public class GetStationsQueryHandler(
    IStationRepository repository,
    IMapper mapper) : IRequestHandler<GetStationsQuery, List<StationDto>>
{
    public async Task<List<StationDto>> Handle(GetStationsQuery request, CancellationToken cancellationToken)
    {
        var items = await repository.GetAllAsync(x => true);
        return items.Select(mapper.Map<StationDto>).ToList();
    }
}
