using Application.Features.Plcs.Dtos;
using MediatR;

namespace Application.Features.Plcs.Queries.GetById;

public record GetPlcByIdQuery(int Id) : IRequest<PlcDto?>;
