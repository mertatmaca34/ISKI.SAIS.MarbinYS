using Application.Features.AnalogSensorData.Dtos;
using Application.Services.Repositories;
using AutoMapper;
using MediatR;

namespace Application.Features.AnalogSensorData.Queries.GetList;

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
