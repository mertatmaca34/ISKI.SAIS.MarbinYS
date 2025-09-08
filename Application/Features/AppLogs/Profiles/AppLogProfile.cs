using AutoMapper;
using Domain.Entities;
using Application.Features.AppLogs.Dtos;

namespace Application.Features.AppLogs.Profiles;

public class AppLogProfile : Profile
{
    public AppLogProfile()
    {
        CreateMap<AppLog, AppLogDto>();
    }
}
