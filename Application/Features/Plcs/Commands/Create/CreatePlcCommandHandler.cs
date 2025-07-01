using Application.Features.Plcs.Dtos;
using AutoMapper;
using Domain.Entities;
using Infrastructure.Persistence.Abstract;
using MediatR;

namespace Application.Features.Plcs.Commands.Create;

public class CreatePlcCommandHandler(
    IPlcRepository repository,
    IMapper mapper) : IRequestHandler<CreatePlcCommand, PlcDto>
{
    public async Task<PlcDto> Handle(CreatePlcCommand request, CancellationToken cancellationToken)
    {
        var entity = mapper.Map<Plc>(request);
        entity = await repository.AddAsync(entity);
        return mapper.Map<PlcDto>(entity);
    }
}
