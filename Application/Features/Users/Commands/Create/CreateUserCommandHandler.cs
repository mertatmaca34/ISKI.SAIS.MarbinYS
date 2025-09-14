using Application.Features.Users.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Repositories;
using MediatR;

namespace Application.Features.Users.Commands.Create;

public class CreateUserCommandHandler(
    IUserRepository repository,
    IMapper mapper) : IRequestHandler<CreateUserCommand, UserDto>
{
    public async Task<UserDto> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var entity = mapper.Map<User>(request);
        entity = await repository.AddAsync(entity);
        return mapper.Map<UserDto>(entity);
    }
}

