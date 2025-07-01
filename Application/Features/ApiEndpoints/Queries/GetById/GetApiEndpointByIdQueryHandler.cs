using Application.Features.ApiEndpoints.Dtos;
using AutoMapper;
using Infrastructure.Persistence.Abstract;
using MediatR;

namespace Application.Features.ApiEndpoints.Queries.GetById;

public class GetApiEndpointByIdQueryHandler(
    IApiEndpointRepository repository,
    IMapper mapper) : IRequestHandler<GetApiEndpointByIdQuery, ApiEndpointDto?>
{
    public async Task<ApiEndpointDto?> Handle(GetApiEndpointByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        return entity is null ? null : mapper.Map<ApiEndpointDto>(entity);
    }
}
