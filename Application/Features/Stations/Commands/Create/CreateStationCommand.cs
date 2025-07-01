using Application.Features.Stations.Dtos;
using MediatR;

namespace Application.Features.Stations.Commands.Create;

public record CreateStationCommand(string StationName, Guid StationId) : IRequest<StationDto>;
