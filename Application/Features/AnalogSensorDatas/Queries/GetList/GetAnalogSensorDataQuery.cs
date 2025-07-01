using Application.Features.AnalogSensorDatas.Dtos;
using MediatR;

namespace Application.Features.AnalogSensorDatas.Queries.GetList;

public record GetAnalogSensorDataQuery() : IRequest<List<AnalogSensorDataDto>>;
