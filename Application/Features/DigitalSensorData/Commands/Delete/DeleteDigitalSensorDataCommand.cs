using MediatR;

namespace Application.Features.DigitalSensorData.Commands.Delete;

public record DeleteDigitalSensorDataCommand(int Id) : IRequest<bool>;
