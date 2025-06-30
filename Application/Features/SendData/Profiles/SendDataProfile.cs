using Application.Features.MailLogs.Dtos;
using Application.Features.SendData.Dtos;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.SendData.Profiles;

public class SendDataProfile : Profile
{
    public SendDataProfile()
    {
        CreateMap<MailLog, MailLogDto>();
        CreateMap<SendData, SendDataDto>();
    }
}
