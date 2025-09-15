using Application.Features.SendDatas.Dtos;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.SendDatas.Profiles;

public class SendDataProfile : Profile
{
    public SendDataProfile()
    {
        CreateMap<SendData, SendDataDto>();
        CreateMap<Commands.Create.CreateSendDataCommand, SendData>();
    }
}
