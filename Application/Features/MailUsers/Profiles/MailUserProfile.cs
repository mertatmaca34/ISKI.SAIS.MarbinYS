using Application.Features.MailUsers.Dtos;
using Application.Features.MailUsers.Commands.Create;
using Application.Features.MailUsers.Commands.Update;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.MailUsers.Profiles;

public class MailUserProfile : Profile
{
    public MailUserProfile()
    {
        CreateMap<MailUser, MailUserDto>();
        CreateMap<CreateMailUserCommand, MailUser>();
        CreateMap<UpdateMailUserCommand, MailUser>();
    }
}
