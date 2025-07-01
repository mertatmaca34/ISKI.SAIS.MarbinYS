using Application.Features.DigitalSensorData.Dtos;
using MediatR;

namespace Application.Features.DigitalSensorData.Queries.GetList;

public record GetDigitalSensorDataQuery() : IRequest<List<DigitalSensorDataDto>>;
