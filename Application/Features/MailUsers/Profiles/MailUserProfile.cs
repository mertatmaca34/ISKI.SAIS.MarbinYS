using Application.Features.MailUsers.Dtos;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.MailUsers.Profiles;

public class MailUserProfile : Profile
{
    public MailUserProfile()
    {
        CreateMap<MailUser, MailUserDto>();
    }
}
