using Application.Features.ApiEndpoints.Dtos;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.ApiEndpoints.Commands.Create;

public class CreateApiEndpointCommandHandler(
    IApiEndpointRepository repository,
    IMapper mapper) : IRequestHandler<CreateApiEndpointCommand, ApiEndpointDto>
{
    public async Task<ApiEndpointDto> Handle(CreateApiEndpointCommand request, CancellationToken cancellationToken)
    {
        var entity = mapper.Map<ApiEndpoint>(request);
        entity = await repository.AddAsync(entity);
        return mapper.Map<ApiEndpointDto>(entity);
    }
}
