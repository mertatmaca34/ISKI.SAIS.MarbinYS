using MediatR;

namespace Application.Features.AnalogSensorDatas.Commands.Delete;

public record DeleteAnalogSensorDataCommand(int Id) : IRequest<bool>;
