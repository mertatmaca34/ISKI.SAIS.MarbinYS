using Application.Features.PlcInformations.Dtos;
using MediatR;

namespace Application.Features.PlcInformations.Queries.GetList;

public record GetPlcInformationsQuery() : IRequest<List<PlcInformationDto>>;
