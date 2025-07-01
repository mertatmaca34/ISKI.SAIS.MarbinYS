using Application.Features.CalibrationMeasurements.Dtos;
using MediatR;

namespace Application.Features.CalibrationMeasurements.Commands.Create;

public record CreateCalibrationMeasurementCommand(
    DateTime TimeStamp,
    string Parameter,
    double ZeroRef,
    double ZeroMeas,
    double ZeroDiff,
    double ZeroStd,
    double SpanRef,
    double SpanMeas,
    double SpanDiff,
    double SpanStd,
    double ResultFactor,
    bool IsItValid) : IRequest<CalibrationMeasurementDto>;
