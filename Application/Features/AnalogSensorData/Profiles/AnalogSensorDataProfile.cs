using Application.Features.AnalogSensorData.Commands.Create;
using Application.Features.AnalogSensorData.Commands.Update;
using Application.Features.AnalogSensorData.Dtos;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.AnalogSensorData.Profiles;

public class AnalogSensorDataProfile : Profile
{
    public AnalogSensorDataProfile()
    {
        CreateMap<AnalogSensorData, AnalogSensorDataDto>();
        CreateMap<CreateAnalogSensorDataCommand, AnalogSensorData>();
        CreateMap<UpdateAnalogSensorDataCommand, AnalogSensorData>();
    }
}
