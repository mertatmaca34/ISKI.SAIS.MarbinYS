using Application.Features.AnalogSensorDatas.Dtos;
using AutoMapper;
using Domain.Repositories;
using MediatR;

namespace Application.Features.AnalogSensorDatas.Queries.GetById;

public class GetAnalogSensorDataByIdQueryHandler(
    IAnalogSensorDataRepository repository,
    IMapper mapper) : IRequestHandler<GetAnalogSensorDataByIdQuery, AnalogSensorDataDto?>
{
    public async Task<AnalogSensorDataDto?> Handle(GetAnalogSensorDataByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        return entity is null ? null : mapper.Map<AnalogSensorDataDto>(entity);
    }
}
