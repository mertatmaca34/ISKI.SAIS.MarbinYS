using Application.Features.Plcs.Dtos;
using AutoMapper;
using Infrastructure.Persistence.Abstract;
using MediatR;

namespace Application.Features.Plcs.Commands.Update;

public class UpdatePlcCommandHandler(
    IPlcRepository repository,
    IMapper mapper) : IRequestHandler<UpdatePlcCommand, PlcDto>
{
    public async Task<PlcDto> Handle(UpdatePlcCommand request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        if (entity is null)
            throw new KeyNotFoundException($"Plc {request.Id} not found");
        mapper.Map(request, entity);
        entity = await repository.UpdateAsync(entity);
        return mapper.Map<PlcDto>(entity);
    }
}
