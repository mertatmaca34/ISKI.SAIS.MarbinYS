using Application.Features.DigitalSensorDatas.Dtos;
using AutoMapper;
using Domain.Repositories;
using MediatR;

namespace Application.Features.DigitalSensorDatas.Queries.GetList;

public class GetDigitalSensorDataQueryHandler(
    IDigitalSensorDataRepository repository,
    IMapper mapper) : IRequestHandler<GetDigitalSensorDataQuery, List<DigitalSensorDataDto>>
{
    public async Task<List<DigitalSensorDataDto>> Handle(GetDigitalSensorDataQuery request, CancellationToken cancellationToken)
    {
        var items = await repository.GetAllAsync(x => true);
        return items.Select(mapper.Map<DigitalSensorDataDto>).ToList();
    }
}
