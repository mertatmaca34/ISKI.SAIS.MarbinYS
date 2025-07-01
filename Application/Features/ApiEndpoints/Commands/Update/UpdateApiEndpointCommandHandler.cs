using Application.Features.ApiEndpoints.Dtos;
using AutoMapper;
using Infrastructure.Persistence.Abstract;
using MediatR;

namespace Application.Features.ApiEndpoints.Commands.Update;

public class UpdateApiEndpointCommandHandler(
    IApiEndpointRepository repository,
    IMapper mapper) : IRequestHandler<UpdateApiEndpointCommand, ApiEndpointDto>
{
    public async Task<ApiEndpointDto> Handle(UpdateApiEndpointCommand request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        if (entity is null)
            throw new KeyNotFoundException($"ApiEndpoint {request.Id} not found");
        mapper.Map(request, entity);
        entity = await repository.UpdateAsync(entity);
        return mapper.Map<ApiEndpointDto>(entity);
    }
}
