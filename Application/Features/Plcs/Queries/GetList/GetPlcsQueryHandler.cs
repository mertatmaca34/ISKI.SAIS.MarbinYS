using Application.Features.Plcs.Dtos;
using Application.Services.Repositories;
using AutoMapper;
using MediatR;

namespace Application.Features.Plcs.Queries.GetList;

public class GetPlcsQueryHandler(
    IPlcRepository repository,
    IMapper mapper) : IRequestHandler<GetPlcsQuery, List<PlcDto>>
{
    public async Task<List<PlcDto>> Handle(GetPlcsQuery request, CancellationToken cancellationToken)
    {
        var items = await repository.GetAllAsync(x => true);
        return items.Select(mapper.Map<PlcDto>).ToList();
    }
}
