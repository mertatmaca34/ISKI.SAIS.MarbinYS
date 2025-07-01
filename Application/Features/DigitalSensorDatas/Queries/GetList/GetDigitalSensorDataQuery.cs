using Application.Features.DigitalSensorDatas.Dtos;
using MediatR;

namespace Application.Features.DigitalSensorDatas.Queries.GetList;

public record GetDigitalSensorDataQuery() : IRequest<List<DigitalSensorDataDto>>;
