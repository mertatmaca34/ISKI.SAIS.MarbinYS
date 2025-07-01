using MediatR;

namespace Application.Features.AnalogSensorData.Commands.Delete;

public record DeleteAnalogSensorDataCommand(int Id) : IRequest<bool>;
