using Application.Features.PlcInformations.Commands.Create;
using Application.Features.PlcInformations.Commands.Update;
using Application.Features.PlcInformations.Dtos;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.PlcInformations.Profiles;

public class PlcInformationProfile : Profile
{
    public PlcInformationProfile()
    {
        CreateMap<PlcInformation, PlcInformationDto>();
        CreateMap<CreatePlcInformationCommand, PlcInformation>();
        CreateMap<UpdatePlcInformationCommand, PlcInformation>();
    }
}
