using Application.Features.MailAlarms.Dtos;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.MailAlarms.Profiles;

public class MailAlarmProfile : Profile
{
    public MailAlarmProfile()
    {
        CreateMap<MailAlarm, MailAlarmDto>().ReverseMap();
    }
}

