using Application.Features.ApiEndpoints.Dtos;
using MediatR;

namespace Application.Features.ApiEndpoints.Commands.Update;

public record UpdateApiEndpointCommand(
    int Id,
    string ApiAdress,
    string UserName,
    string Password) : IRequest<ApiEndpointDto>;
