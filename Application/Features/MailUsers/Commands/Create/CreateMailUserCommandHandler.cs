using Application.Features.MailUsers.Dtos;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.MailUsers.Commands.Create;

public class CreateMailUserCommandHandler(
    IMailUserRepository repository,
    IMapper mapper) : IRequestHandler<CreateMailUserCommand, MailUserDto>
{
    public async Task<MailUserDto> Handle(CreateMailUserCommand request, CancellationToken cancellationToken)
    {
        var entity = mapper.Map<MailUser>(request);
        entity = await repository.AddAsync(entity);
        return mapper.Map<MailUserDto>(entity);
    }
}
