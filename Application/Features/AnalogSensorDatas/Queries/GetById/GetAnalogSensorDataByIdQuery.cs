using Application.Features.AnalogSensorDatas.Dtos;
using MediatR;

namespace Application.Features.AnalogSensorDatas.Queries.GetById;

public record GetAnalogSensorDataByIdQuery(int Id) : IRequest<AnalogSensorDataDto?>;
