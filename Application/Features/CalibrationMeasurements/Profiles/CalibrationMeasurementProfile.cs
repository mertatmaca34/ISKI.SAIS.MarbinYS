using Application.Features.CalibrationMeasurements.Commands.Create;
using Application.Features.CalibrationMeasurements.Commands.Update;
using Application.Features.CalibrationMeasurements.Dtos;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.CalibrationMeasurements.Profiles;

public class CalibrationMeasurementProfile : Profile
{
    public CalibrationMeasurementProfile()
    {
        CreateMap<CalibrationMeasurement, CalibrationMeasurementDto>();
        CreateMap<CreateCalibrationMeasurementCommand, CalibrationMeasurement>();
        CreateMap<UpdateCalibrationMeasurementCommand, CalibrationMeasurement>();
    }
}
