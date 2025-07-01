using Application.Features.CalibrationLimits.Dtos;
using MediatR;

namespace Application.Features.CalibrationLimits.Commands.Create;

public record CreateCalibrationLimitCommand(
    string Parameter,
    int ZeroRef,
    int ZeroTimeStamp,
    int SpanRef,
    int SpanTimeStamp) : IRequest<CalibrationLimitDto>;
