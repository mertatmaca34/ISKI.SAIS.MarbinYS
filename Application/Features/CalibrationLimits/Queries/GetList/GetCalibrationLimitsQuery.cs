using Application.Features.CalibrationLimits.Dtos;
using MediatR;

namespace Application.Features.CalibrationLimits.Queries.GetList;

public record GetCalibrationLimitsQuery() : IRequest<List<CalibrationLimitDto>>;
