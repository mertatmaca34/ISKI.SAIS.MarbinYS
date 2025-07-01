using Application.Features.DigitalSensorData.Dtos;
using MediatR;

namespace Application.Features.DigitalSensorData.Queries.GetById;

public record GetDigitalSensorDataByIdQuery(int Id) : IRequest<DigitalSensorDataDto?>;
