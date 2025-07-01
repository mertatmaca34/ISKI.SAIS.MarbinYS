using Application.Features.Stations.Dtos;
using MediatR;

namespace Application.Features.Stations.Queries.GetById;

public record GetStationByIdQuery(int Id) : IRequest<StationDto?>;
