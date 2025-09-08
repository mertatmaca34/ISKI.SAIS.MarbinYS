using System;
using Application.Features.Stations.Dtos;
using MediatR;

namespace Application.Features.Stations.Commands.Create;

public record CreateStationCommand(
    Guid StationId,
    string Code,
    string Name,
    short? DataPeriodMinute,
    DateTime? LastDataDate,
    string ConnectionDomainAddress,
    int? ConnectionPort,
    string ConnectionUser,
    string ConnectionPassword,
    string Company,
    DateTime? BirtDate,
    DateTime? SetupDate,
    string Address,
    string Software
) : IRequest<StationDto>;
