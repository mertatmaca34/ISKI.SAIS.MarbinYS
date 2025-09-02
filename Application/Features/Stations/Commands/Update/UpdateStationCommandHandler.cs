using Application.Features.Stations.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Enums;
using Infrastructure.Persistence.Abstract;
using MediatR;

namespace Application.Features.Stations.Commands.Update;

public class UpdateStationCommandHandler(
    IStationRepository repository,
    IAppLogRepository logRepository,
    IMapper mapper) : IRequestHandler<UpdateStationCommand, StationDto>
{
    public async Task<StationDto> Handle(UpdateStationCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var entity = await repository.GetByIdAsync(request.Id);
            if (entity is null)
                throw new KeyNotFoundException($"Station {request.Id} not found");

            mapper.Map(request, entity);
            entity = await repository.UpdateAsync(entity);

            await logRepository.AddAsync(new AppLog
            {
                Level = LogLevel.Information,
                Message = $"Station {entity.StationId} updated successfully",
                LoggedAt = DateTime.UtcNow
            });

            return mapper.Map<StationDto>(entity);
        }
        catch (Exception ex)
        {
            await logRepository.AddAsync(new AppLog
            {
                Level = LogLevel.Error,
                Message = $"Error updating station {request.StationId}: {ex.Message}",
                Exception = ex.ToString(),
                LoggedAt = DateTime.UtcNow
            });

            throw;
        }
    }
}
