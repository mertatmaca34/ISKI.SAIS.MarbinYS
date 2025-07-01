using Application.Features.PlcInformations.Dtos;
using MediatR;

namespace Application.Features.PlcInformations.Queries.GetById;

public record GetPlcInformationByIdQuery(int Id) : IRequest<PlcInformationDto?>;
