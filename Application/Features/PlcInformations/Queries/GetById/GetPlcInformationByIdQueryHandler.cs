using Application.Features.PlcInformations.Dtos;
using AutoMapper;
using Infrastructure.Persistence.Abstract;
using MediatR;

namespace Application.Features.PlcInformations.Queries.GetById;

public class GetPlcInformationByIdQueryHandler(
    IPlcInformationRepository repository,
    IMapper mapper) : IRequestHandler<GetPlcInformationByIdQuery, PlcInformationDto?>
{
    public async Task<PlcInformationDto?> Handle(GetPlcInformationByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        return entity is null ? null : mapper.Map<PlcInformationDto>(entity);
    }
}
