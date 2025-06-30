using Application.Features.MailTriggers.Commands.Create;
using Application.Features.MailTriggers.Commands.Update;
using Application.Features.MailTriggers.Dtos;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.MailTriggers.Profiles;

public class MailTriggerProfile : Profile
{
    public MailTriggerProfile()
    {
        CreateMap<CreateMailTriggerCommand, MailTrigger>();
        CreateMap<UpdateMailTriggerCommand, MailTrigger>();
        CreateMap<MailTrigger, MailTriggerDto>()
            .ForMember(dest => dest.Operator, opt => opt.MapFrom(src => (int)src.Operator));
    }
}
