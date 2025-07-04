using Application.Features.MailSettings.Dtos;
using Application.Features.MailSettings.Commands.Create;
using Application.Features.MailSettings.Commands.Update;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.MailSettings.Profiles;

public class MailSettingsProfile : Profile
{
    public MailSettingsProfile()
    {
        CreateMap<MailSetting, MailSettingsDto>();
        CreateMap<CreateMailSettingsCommand, MailSetting>();
        CreateMap<UpdateMailSettingsCommand, MailSetting>();
    }
}
