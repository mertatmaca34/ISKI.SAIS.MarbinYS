using System;
using Application.Constants;
using Application.Features.Stations.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Repositories;
using Serilog;
using MediatR;
using Log = Serilog.Log;

namespace Application.Features.Stations.Commands.Create;

public class CreateStationCommandHandler(
    IStationRepository repository,
    IMapper mapper) : IRequestHandler<CreateStationCommand, StationDto>
{
    public async Task<StationDto> Handle(CreateStationCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var entity = mapper.Map<Station>(request);
            entity = await repository.AddAsync(entity);

            Log.Information(LogMessages.Stations.CreatedSuccessfully, entity.StationId);

            return mapper.Map<StationDto>(entity);
        }
        catch (Exception ex)
        {
            Log.Error(ex, LogMessages.Stations.CreationError, request.StationId);

            throw;
        }
    }
}
