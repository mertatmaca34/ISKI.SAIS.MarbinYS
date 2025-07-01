using Application.Features.AnalogSensorDatas.Dtos;
using MediatR;

namespace Application.Features.AnalogSensorDatas.Commands.Create;

public record CreateAnalogSensorDataCommand(
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
