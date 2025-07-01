using Application.Features.PlcInformations.Dtos;
using MediatR;

namespace Application.Features.PlcInformations.Commands.Create;

public record CreatePlcInformationCommand(string IpAddress) : IRequest<PlcInformationDto>;
