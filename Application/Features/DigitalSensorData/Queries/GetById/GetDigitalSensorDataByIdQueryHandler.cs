using Application.Features.DigitalSensorData.Dtos;
using Application.Services.Repositories;
using AutoMapper;
using MediatR;

namespace Application.Features.DigitalSensorData.Queries.GetById;

public class GetDigitalSensorDataByIdQueryHandler(
    IDigitalSensorDataRepository repository,
    IMapper mapper) : IRequestHandler<GetDigitalSensorDataByIdQuery, DigitalSensorDataDto?>
{
    public async Task<DigitalSensorDataDto?> Handle(GetDigitalSensorDataByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        return entity is null ? null : mapper.Map<DigitalSensorDataDto>(entity);
    }
}
