using Application.Features.CalibrationLimits.Dtos;
using MediatR;

namespace Application.Features.CalibrationLimits.Queries.GetById;

public record GetCalibrationLimitByIdQuery(int Id) : IRequest<CalibrationLimitDto?>;
