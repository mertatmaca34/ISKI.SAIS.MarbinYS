using Application.Features.CalibrationMeasurements.Dtos;
using MediatR;

namespace Application.Features.CalibrationMeasurements.Queries.GetList;

public record GetCalibrationMeasurementsQuery() : IRequest<List<CalibrationMeasurementDto>>;
