using Application.Features.CalibrationLimits.Dtos;
using MediatR;

namespace Application.Features.CalibrationLimits.Commands.Update;

public record UpdateCalibrationLimitCommand(
    int Id,
    string Parameter,
    int ZeroRef,
    int ZeroTimeStamp,
    int SpanRef,
    int SpanTimeStamp) : IRequest<CalibrationLimitDto>;
