using System;
using Application.Features.Stations.Dtos;
using AutoMapper;
using Domain.Entities;
using Infrastructure.Persistence.Abstract;
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
            var entity = await repository.GetAsync(x => x.StationId == request.StationId);
            if (entity is null)
                throw new KeyNotFoundException($"Station {request.StationId} not found");

            mapper.Map(request, entity);
            entity = await repository.UpdateAsync(entity);

            Log.Information("Station {StationId} updated successfully", entity.StationId);

            return mapper.Map<StationDto>(entity);
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error updating station {StationId}", request.StationId);

            throw;
        }
    }
}
