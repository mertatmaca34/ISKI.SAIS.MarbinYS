using Application.Features.Stations.Dtos;
using MediatR;

namespace Application.Features.Stations.Commands.Update;

public record UpdateStationCommand(
    int Id,
    Guid StationId,
    string Code,
    string Name,
    int DataPeriodMinute,
    DateTime LastDataDate,
    string ConnectionDomainAddress,
    string ConnectionPort,
    string ConnectionUser,
    string ConnectionPassword,
    string Company,
    DateTime BirtDate,
    DateTime SetupDate,
    string Address,
    string Software
) : IRequest<StationDto>;
