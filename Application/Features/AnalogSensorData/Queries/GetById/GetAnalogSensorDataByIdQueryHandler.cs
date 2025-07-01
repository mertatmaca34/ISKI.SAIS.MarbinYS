using Application.Features.AnalogSensorData.Dtos;
using Application.Services.Repositories;
using AutoMapper;
using MediatR;

namespace Application.Features.AnalogSensorData.Queries.GetById;

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
