using Application.Features.Users.Dtos;
using MediatR;

namespace Application.Features.Users.Queries.GetList;

public record GetUsersQuery() : IRequest<List<UserDto>>;

