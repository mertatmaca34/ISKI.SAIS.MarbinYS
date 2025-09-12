using Application.Features.PlcData.Dtos;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.PlcData.Profiles;

public class PlcTimeParametersProfile : Profile
{
    public PlcTimeParametersProfile()
    {
        CreateMap<PlcTimeParameters, PlcTimeParametersDto>();
    }
}

