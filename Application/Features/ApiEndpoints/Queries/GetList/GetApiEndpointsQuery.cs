using Application.Features.ApiEndpoints.Dtos;
using MediatR;

namespace Application.Features.ApiEndpoints.Queries.GetList;

public record GetApiEndpointsQuery() : IRequest<List<ApiEndpointDto>>;
