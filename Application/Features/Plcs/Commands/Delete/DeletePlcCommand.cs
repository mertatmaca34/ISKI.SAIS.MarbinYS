using MediatR;

namespace Application.Features.Plcs.Commands.Delete;

public record DeletePlcCommand(int Id) : IRequest<bool>;
