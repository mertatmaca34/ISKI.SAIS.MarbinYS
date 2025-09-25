using System;
using Application.Constants;
using Application.Features.Stations.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Repositories;
using Serilog;
using MediatR;
using Log = Serilog.Log;

namespace Application.Features.Stations.Commands.Update;

public class UpdateStationCommandHandler(
    IStationRepository repository,
    IMapper mapper) : IRequestHandler<UpdateStationCommand, StationDto>
{
    public async Task<StationDto> Handle(UpdateStationCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var entity = await repository.GetAsync(x => x.Id == 1);
            if (entity is null)
                throw new KeyNotFoundException($"Station {request.StationId} not found");

            mapper.Map(request, entity);
            entity = await repository.UpdateAsync(entity);

            Log.Information(LogMessages.Stations.UpdatedSuccessfully, entity.StationId);

            return mapper.Map<StationDto>(entity);
        }
        catch (Exception ex)
        {
            Log.Error(ex, LogMessages.Stations.UpdateError, request.StationId);

            throw;
        }
    }
}
