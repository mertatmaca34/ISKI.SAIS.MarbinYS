using Application.Features.Plcs.Dtos;
using MediatR;

namespace Application.Features.Plcs.Commands.Create;

public record CreatePlcCommand(string IpAddress) : IRequest<PlcDto>;
