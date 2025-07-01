using Application.Features.AnalogSensorDatas.Commands.Create;
using Application.Features.AnalogSensorDatas.Commands.Update;
using Application.Features.AnalogSensorDatas.Dtos;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.AnalogSensorDatas.Profiles;

public class AnalogSensorDataProfile : Profile
{
    public AnalogSensorDataProfile()
    {
        CreateMap<AnalogSensorData, AnalogSensorDataDto>();
        CreateMap<CreateAnalogSensorDataCommand, AnalogSensorData>();
        CreateMap<UpdateAnalogSensorDataCommand, AnalogSensorData>();
    }
}
