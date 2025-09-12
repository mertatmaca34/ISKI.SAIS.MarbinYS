using Application.Features.PlcInformations.Dtos;
using AutoMapper;
using Domain.Repositories;
using MediatR;

namespace Application.Features.PlcInformations.Commands.Update;

public class UpdatePlcInformationCommandHandler(
    IPlcInformationRepository repository,
    IMapper mapper) : IRequestHandler<UpdatePlcInformationCommand, PlcInformationDto>
{
    public async Task<PlcInformationDto> Handle(UpdatePlcInformationCommand request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        if (entity is null)
            throw new KeyNotFoundException($"Plc information {request.Id} not found");
        mapper.Map(request, entity);
        entity = await repository.UpdateAsync(entity);
        return mapper.Map<PlcInformationDto>(entity);
    }
}
