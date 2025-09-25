using System;
using System.Collections.Generic;
using Application.Features.DigitalSensorDatas.Dtos;
using MediatR;

namespace Application.Features.DigitalSensorDatas.Queries.GetByDateRange;

public sealed record GetDigitalSensorDataByDateRangeQuery(DateTime StartDate, DateTime EndDate)
    : IRequest<List<DigitalSensorDataDto>>;
