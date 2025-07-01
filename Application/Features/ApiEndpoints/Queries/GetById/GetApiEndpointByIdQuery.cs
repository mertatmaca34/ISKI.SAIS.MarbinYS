using Application.Features.ApiEndpoints.Dtos;
using MediatR;

namespace Application.Features.ApiEndpoints.Queries.GetById;

public record GetApiEndpointByIdQuery(int Id) : IRequest<ApiEndpointDto?>;
