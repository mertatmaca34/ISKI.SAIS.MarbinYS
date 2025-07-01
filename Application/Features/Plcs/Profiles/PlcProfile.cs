using Application.Features.Plcs.Commands.Create;
using Application.Features.Plcs.Commands.Update;
using Application.Features.Plcs.Dtos;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.Plcs.Profiles;

public class PlcProfile : Profile
{
    public PlcProfile()
    {
        CreateMap<Plc, PlcDto>();
        CreateMap<CreatePlcCommand, Plc>();
        CreateMap<UpdatePlcCommand, Plc>();
    }
}
