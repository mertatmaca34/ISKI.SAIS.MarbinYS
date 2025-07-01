using Application.Features.MailUsers.Dtos;
using AutoMapper;
using Infrastructure.Persistence.Abstract;
using MediatR;

namespace Application.Features.MailUsers.Commands.Update;

public class UpdateMailUserCommandHandler(
    IMailUserRepository repository,
    IMapper mapper) : IRequestHandler<UpdateMailUserCommand, MailUserDto>
{
    public async Task<MailUserDto> Handle(UpdateMailUserCommand request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        if (entity is null)
            throw new KeyNotFoundException($"MailUser {request.Id} not found");

        mapper.Map(request, entity);
        entity = await repository.UpdateAsync(entity);
        return mapper.Map<MailUserDto>(entity);
    }
}
