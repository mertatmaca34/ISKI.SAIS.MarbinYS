using Application.Features.ApiEndpoints.Dtos;
using MediatR;

namespace Application.Features.ApiEndpoints.Commands.Create;

public record CreateApiEndpointCommand(
    string ApiAddress,
    string UserName,
    string Password,
    int? DataSendPeriodMinute,
    int? ResendDataPeriodMinute) : IRequest<ApiEndpointDto>;
