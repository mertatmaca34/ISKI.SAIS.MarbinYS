using Application.Features.Stations.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Enums;
using Infrastructure.Persistence.Abstract;
using MediatR;

namespace Application.Features.Stations.Commands.Create;

public class CreateStationCommandHandler(
    IStationRepository repository,
    IAppLogRepository logRepository,
    IMapper mapper) : IRequestHandler<CreateStationCommand, StationDto>
{
    public async Task<StationDto> Handle(CreateStationCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var entity = mapper.Map<Station>(request);
            entity = await repository.AddAsync(entity);

            await logRepository.AddAsync(new AppLog
            {
                Level = LogLevel.Information,
                Message = $"Station {entity.StationId} created successfully",
                LoggedAt = DateTime.UtcNow
            });

            return mapper.Map<StationDto>(entity);
        }
        catch (Exception ex)
        {
            await logRepository.AddAsync(new AppLog
            {
                Level = LogLevel.Error,
                Message = $"Error creating station {request.StationId}: {ex.Message}",
                Exception = ex.ToString(),
                LoggedAt = DateTime.UtcNow
            });

            throw;
        }
    }
}
