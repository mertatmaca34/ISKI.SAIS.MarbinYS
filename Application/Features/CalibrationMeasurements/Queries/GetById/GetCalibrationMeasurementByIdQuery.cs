using Application.Features.CalibrationMeasurements.Dtos;
using MediatR;

namespace Application.Features.CalibrationMeasurements.Queries.GetById;

public record GetCalibrationMeasurementByIdQuery(int Id) : IRequest<CalibrationMeasurementDto?>;
