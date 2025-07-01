using MediatR;

namespace Application.Features.Stations.Commands.Delete;

public record DeleteStationCommand(int Id) : IRequest<bool>;
