using Application.Features.Stations.Dtos;
using MediatR;

namespace Application.Features.Stations.Queries.GetList;

public record GetStationsQuery() : IRequest<List<StationDto>>;
