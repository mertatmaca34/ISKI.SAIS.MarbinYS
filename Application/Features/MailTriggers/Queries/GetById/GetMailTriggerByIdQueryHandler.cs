using MediatR;
using Application.Features.MailTriggers.Dtos;
using Application.Services.Repositories;
using AutoMapper;

namespace Application.Features.MailTriggers.Queries.GetById;

public class GetMailTriggerByIdQueryHandler(
    IMailTriggerRepository repository,
    IMapper mapper)
    : IRequestHandler<GetMailTriggerByIdQuery, MailTriggerDto?>
{
    public async Task<MailTriggerDto?> Handle(GetMailTriggerByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        if (entity is null)
            return null;

        return mapper.Map<MailTriggerDto>(entity);
    }
}
