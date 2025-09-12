using Application.Features.MailSettings.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Repositories;
using MediatR;

namespace Application.Features.MailSettings.Commands.Create;

public class CreateMailSettingsCommandHandler(
    IMailSettingsRepository repository,
    IMapper mapper) : IRequestHandler<CreateMailSettingsCommand, MailSettingsDto>
{
    public async Task<MailSettingsDto> Handle(CreateMailSettingsCommand request, CancellationToken cancellationToken)
    {
        var entity = mapper.Map<MailSetting>(request);
        entity = await repository.AddAsync(entity);
        return mapper.Map<MailSettingsDto>(entity);
    }
}
