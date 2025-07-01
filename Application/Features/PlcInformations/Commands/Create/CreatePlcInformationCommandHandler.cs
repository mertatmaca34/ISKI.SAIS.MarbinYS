using Application.Features.PlcInformations.Dtos;
using AutoMapper;
using Domain.Entities;
using Infrastructure.Persistence.Abstract;
using MediatR;

namespace Application.Features.PlcInformations.Commands.Create;

public class CreatePlcInformationCommandHandler(
    IPlcInformationRepository repository,
    IMapper mapper) : IRequestHandler<CreatePlcInformationCommand, PlcInformationDto>
{
    public async Task<PlcInformationDto> Handle(CreatePlcInformationCommand request, CancellationToken cancellationToken)
    {
        var entity = mapper.Map<PlcInformation>(request);
        entity = await repository.AddAsync(entity);
        return mapper.Map<PlcInformationDto>(entity);
    }
}
