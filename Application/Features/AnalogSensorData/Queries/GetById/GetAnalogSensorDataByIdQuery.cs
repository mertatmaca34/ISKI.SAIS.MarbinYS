using Application.Features.AnalogSensorData.Dtos;
using MediatR;

namespace Application.Features.AnalogSensorData.Queries.GetById;

public record GetAnalogSensorDataByIdQuery(int Id) : IRequest<AnalogSensorDataDto?>;
