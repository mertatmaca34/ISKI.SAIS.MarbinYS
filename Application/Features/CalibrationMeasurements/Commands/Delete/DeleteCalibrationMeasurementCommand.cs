using MediatR;

namespace Application.Features.CalibrationMeasurements.Commands.Delete;

public record DeleteCalibrationMeasurementCommand(int Id) : IRequest<bool>;
