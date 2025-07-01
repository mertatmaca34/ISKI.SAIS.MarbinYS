using Application.Features.MailSettings.Dtos;
using AutoMapper;
using Infrastructure.Persistence.Abstract;
using MediatR;

namespace Application.Features.MailSettings.Commands.Update;

public class UpdateMailSettingsCommandHandler(
    IMailSettingsRepository repository,
    IMapper mapper) : IRequestHandler<UpdateMailSettingsCommand, MailSettingsDto>
{
    public async Task<MailSettingsDto> Handle(UpdateMailSettingsCommand request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        if (entity is null)
            throw new KeyNotFoundException($"MailSettings {request.Id} not found");

        mapper.Map(request, entity);
        entity = await repository.UpdateAsync(entity);
        return mapper.Map<MailSettingsDto>(entity);
    }
}
