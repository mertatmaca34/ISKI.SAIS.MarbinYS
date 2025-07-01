using Application.Features.CalibrationLimits.Commands.Create;
using Application.Features.CalibrationLimits.Commands.Update;
using Application.Features.CalibrationLimits.Dtos;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.CalibrationLimits.Profiles;

public class CalibrationLimitProfile : Profile
{
    public CalibrationLimitProfile()
    {
        CreateMap<CalibrationLimit, CalibrationLimitDto>();
        CreateMap<CreateCalibrationLimitCommand, CalibrationLimit>();
        CreateMap<UpdateCalibrationLimitCommand, CalibrationLimit>();
    }
}
