using System;
using Application.Features.MailAlarms.Dtos;
using AutoMapper;
using Domain.Repositories;
using MediatR;

namespace Application.Features.MailAlarms.Commands.Update;

public class UpdateMailAlarmCommandHandler(IMailAlarmRepository repository, IMapper mapper)
    : IRequestHandler<UpdateMailAlarmCommand, MailAlarmDto>
{
    public async Task<MailAlarmDto> Handle(UpdateMailAlarmCommand request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetAsync(x => x.Id == request.Id);
        if (entity == null)
            throw new Exception("Alarm not found");

        entity.Name = request.Name;
        entity.Channel = request.Channel;
        entity.Limit = request.Limit;
        entity.MailSubject = request.MailSubject;
        entity.MailBody = request.MailBody;
        entity.TemplateType = request.TemplateType;
        await repository.UpdateAsync(entity);
        return mapper.Map<MailAlarmDto>(entity);
    }
}
