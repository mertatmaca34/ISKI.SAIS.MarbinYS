using Application.Features.DigitalSensorDatas.Dtos;
using MediatR;

namespace Application.Features.DigitalSensorDatas.Queries.GetById;

public record GetDigitalSensorDataByIdQuery(int Id) : IRequest<DigitalSensorDataDto?>;
