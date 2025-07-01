using Application.Features.DigitalSensorDatas.Commands.Create;
using Application.Features.DigitalSensorDatas.Commands.Update;
using Application.Features.DigitalSensorDatas.Dtos;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.DigitalSensorDatas.Profiles;

public class DigitalSensorDataProfile : Profile
{
    public DigitalSensorDataProfile()
    {
        CreateMap<DigitalSensorData, DigitalSensorDataDto>();
        CreateMap<CreateDigitalSensorDataCommand, DigitalSensorData>();
        CreateMap<UpdateDigitalSensorDataCommand, DigitalSensorData>();
    }
}
