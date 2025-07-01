using Application.Features.Plcs.Dtos;
using AutoMapper;
using Infrastructure.Persistence.Abstract;
using MediatR;

namespace Application.Features.Plcs.Queries.GetById;

public class GetPlcByIdQueryHandler(
    IPlcRepository repository,
    IMapper mapper) : IRequestHandler<GetPlcByIdQuery, PlcDto?>
{
    public async Task<PlcDto?> Handle(GetPlcByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        return entity is null ? null : mapper.Map<PlcDto>(entity);
    }
}
