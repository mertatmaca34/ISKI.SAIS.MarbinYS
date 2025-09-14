using Application.Features.Users.Commands.Create;
using Application.Features.Users.Commands.Update;
using Application.Features.Users.Dtos;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.Users.Profiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<User, UserDto>();
        CreateMap<CreateUserCommand, User>();
        CreateMap<UpdateUserCommand, User>();
    }
}

