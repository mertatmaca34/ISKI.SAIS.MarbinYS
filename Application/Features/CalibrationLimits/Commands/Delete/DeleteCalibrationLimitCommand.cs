using MediatR;

namespace Application.Features.CalibrationLimits.Commands.Delete;

public record DeleteCalibrationLimitCommand(int Id) : IRequest<bool>;
