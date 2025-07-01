using MediatR;

namespace Application.Features.PlcInformations.Commands.Delete;

public record DeletePlcInformationCommand(int Id) : IRequest<bool>;
