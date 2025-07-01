using Application.Features.AnalogSensorData.Dtos;
using MediatR;

namespace Application.Features.AnalogSensorData.Queries.GetList;

public record GetAnalogSensorDataQuery() : IRequest<List<AnalogSensorDataDto>>;
