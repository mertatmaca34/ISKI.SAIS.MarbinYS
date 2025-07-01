using Application.Features.ApiEndpoints.Commands.Create;
using Application.Features.ApiEndpoints.Commands.Update;
using Application.Features.ApiEndpoints.Dtos;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.ApiEndpoints.Profiles;

public class ApiEndpointProfile : Profile
{
    public ApiEndpointProfile()
    {
        CreateMap<ApiEndpoint, ApiEndpointDto>();
        CreateMap<CreateApiEndpointCommand, ApiEndpoint>();
        CreateMap<UpdateApiEndpointCommand, ApiEndpoint>();
    }
}
