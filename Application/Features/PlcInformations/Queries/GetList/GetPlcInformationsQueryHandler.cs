using Application.Features.PlcInformations.Dtos;
using AutoMapper;
using Infrastructure.Persistence.Abstract;
using MediatR;

namespace Application.Features.PlcInformations.Queries.GetList;

public class GetPlcInformationsQueryHandler(
    IPlcInformationRepository repository,
    IMapper mapper) : IRequestHandler<GetPlcInformationsQuery, List<PlcInformationDto>>
{
    public async Task<List<PlcInformationDto>> Handle(GetPlcInformationsQuery request, CancellationToken cancellationToken)
    {
        var items = await repository.GetAllAsync(x => true);
        return items.Select(mapper.Map<PlcInformationDto>).ToList();
    }
}
