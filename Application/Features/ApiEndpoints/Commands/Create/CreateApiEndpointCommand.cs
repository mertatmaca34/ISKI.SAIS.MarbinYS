using Application.Features.ApiEndpoints.Dtos;
using MediatR;

namespace Application.Features.ApiEndpoints.Commands.Create;

public record CreateApiEndpointCommand(
    string ApiAdress,
    string UserName,
    string Password) : IRequest<ApiEndpointDto>;
