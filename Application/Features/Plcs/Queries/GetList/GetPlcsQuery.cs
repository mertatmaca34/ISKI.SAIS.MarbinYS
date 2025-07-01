using Application.Features.Plcs.Dtos;
using MediatR;

namespace Application.Features.Plcs.Queries.GetList;

public record GetPlcsQuery() : IRequest<List<PlcDto>>;
