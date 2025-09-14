using Application.Features.Users.Dtos;
using AutoMapper;
using Domain.Repositories;
using MediatR;

namespace Application.Features.Users.Queries.GetList;

public class GetUsersQueryHandler(
    IUserRepository repository,
    IMapper mapper) : IRequestHandler<GetUsersQuery, List<UserDto>>
{
    public async Task<List<UserDto>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
    {
        var items = await repository.GetAllAsync(x => true);
        return items.Select(mapper.Map<UserDto>).ToList();
    }
}

