using Application.Features.PlcData.Dtos;
using AutoMapper;

namespace Application.Features.PlcData.Profiles;

public class PlcDataProfile : Profile
{
    public PlcDataProfile()
    {
        CreateMap<Domain.Entities.PlcData, PlcDataDto>()
            .ForMember(dest => dest.AnalogHourlyAverage,
                opt => opt.MapFrom(_ => new AnalogSensorAverageDto()));
    }
}
