using Application.Features.Users.Dtos;
using Application.Features.Users.Rules;
using AutoMapper;
using Domain.Repositories;
using MediatR;

namespace Application.Features.Users.Commands.Update;

public class UpdateUserCommandHandler(
    IUserRepository repository,
    IMapper mapper) : IRequestHandler<UpdateUserCommand, UserDto>
{
    public async Task<UserDto> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        UserBusinessRules.EntityShouldNotBeNull(entity);
        mapper.Map(request, entity);
        entity = await repository.UpdateAsync(entity!);
        return mapper.Map<UserDto>(entity);
    }
}

