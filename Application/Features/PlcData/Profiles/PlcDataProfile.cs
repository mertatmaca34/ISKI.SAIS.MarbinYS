using Application.Features.PlcData.Dtos;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.PlcData.Profiles;

public class PlcDataProfile : Profile
{
    public PlcDataProfile()
    {
        CreateMap<PlcData, PlcDataDto>();
    }
}

