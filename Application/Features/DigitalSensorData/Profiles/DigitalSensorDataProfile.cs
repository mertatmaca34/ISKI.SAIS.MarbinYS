using Application.Features.DigitalSensorData.Commands.Create;
using Application.Features.DigitalSensorData.Commands.Update;
using Application.Features.DigitalSensorData.Dtos;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.DigitalSensorData.Profiles;

public class DigitalSensorDataProfile : Profile
{
    public DigitalSensorDataProfile()
    {
        CreateMap<DigitalSensorData, DigitalSensorDataDto>();
        CreateMap<CreateDigitalSensorDataCommand, DigitalSensorData>();
        CreateMap<UpdateDigitalSensorDataCommand, DigitalSensorData>();
    }
}
