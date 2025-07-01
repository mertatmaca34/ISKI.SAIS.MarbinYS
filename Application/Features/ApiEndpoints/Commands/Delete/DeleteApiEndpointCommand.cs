using MediatR;

namespace Application.Features.ApiEndpoints.Commands.Delete;

public record DeleteApiEndpointCommand(int Id) : IRequest<bool>;
