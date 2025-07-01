using Application.Features.ApiEndpoints.Dtos;
using Application.Services.Repositories;
using AutoMapper;
using MediatR;

namespace Application.Features.ApiEndpoints.Queries.GetList;

public class GetApiEndpointsQueryHandler(
    IApiEndpointRepository repository,
    IMapper mapper) : IRequestHandler<GetApiEndpointsQuery, List<ApiEndpointDto>>
{
    public async Task<List<ApiEndpointDto>> Handle(GetApiEndpointsQuery request, CancellationToken cancellationToken)
    {
        var items = await repository.GetAllAsync(x => true);
        return items.Select(mapper.Map<ApiEndpointDto>).ToList();
    }
}
