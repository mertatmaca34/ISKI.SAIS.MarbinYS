using Application.Features.AnalogSensorDatas.Dtos;
using AutoMapper;
using Infrastructure.Persistence.Abstract;
using MediatR;

namespace Application.Features.AnalogSensorDatas.Queries.GetList;

public class GetAnalogSensorDataQueryHandler(
    IAnalogSensorDataRepository repository,
    IMapper mapper) : IRequestHandler<GetAnalogSensorDataQuery, List<AnalogSensorDataDto>>
{
    public async Task<List<AnalogSensorDataDto>> Handle(GetAnalogSensorDataQuery request, CancellationToken cancellationToken)
    {
        var items = await repository.GetAllAsync(x => true);
        return items.Select(mapper.Map<AnalogSensorDataDto>).ToList();
    }
}
