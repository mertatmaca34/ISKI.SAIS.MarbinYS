using Application.Features.AnalogSensorDatas.Dtos;
using MediatR;

namespace Application.Features.AnalogSensorDatas.Commands.Update;

public record UpdateAnalogSensorDataCommand(
    int Id,
    DateTime Readtime,
    double AkisHizi,
    double Akm,
    double CozunmusOksijen,
    double Debi,
    double? DesarjDebi,
    double? HariciDebi,
    double? HariciDebi2,
    double Koi,
    double Ph,
    double Sicaklik,
    double Iletkenlik) : IRequest<AnalogSensorDataDto>;
