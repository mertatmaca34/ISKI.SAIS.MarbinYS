using Application.Features.MailSettings.Dtos;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.MailSettings.Profiles;

public class MailSettingsProfile : Profile
{
    public MailSettingsProfile()
    {
        CreateMap<MailSettings, MailSettingsDto>();
    }
}
