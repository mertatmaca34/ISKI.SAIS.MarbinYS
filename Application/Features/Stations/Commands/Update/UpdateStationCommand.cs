using Application.Features.Stations.Dtos;
using MediatR;

namespace Application.Features.Stations.Commands.Update;

public record UpdateStationCommand(int Id, string StationName, Guid StationId) : IRequest<StationDto>;
