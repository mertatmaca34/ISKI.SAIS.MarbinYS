using MediatR;

namespace Application.Features.DigitalSensorDatas.Commands.Delete;

public record DeleteDigitalSensorDataCommand(int Id) : IRequest<bool>;
