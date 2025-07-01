using Application.Features.PlcInformations.Dtos;
using MediatR;

namespace Application.Features.PlcInformations.Commands.Update;

public record UpdatePlcInformationCommand(int Id, string IpAddress) : IRequest<PlcInformationDto>;
