using Application.Features.Stations.Commands.Create;
using Application.Features.Stations.Commands.Update;
using Application.Features.Stations.Dtos;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.Stations.Profiles;

public class StationProfile : Profile
{
    public StationProfile()
    {
        CreateMap<Station, StationDto>();
        CreateMap<CreateStationCommand, Station>();
        CreateMap<UpdateStationCommand, Station>();
    }
}
