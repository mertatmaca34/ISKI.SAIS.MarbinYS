using Application.Features.Plcs.Dtos;
using MediatR;

namespace Application.Features.Plcs.Commands.Update;

public record UpdatePlcCommand(int Id, string IpAddress) : IRequest<PlcDto>;
