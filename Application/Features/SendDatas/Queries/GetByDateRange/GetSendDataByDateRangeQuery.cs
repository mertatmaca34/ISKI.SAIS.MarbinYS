using System;
using System.Collections.Generic;
using Application.Features.SendDatas.Dtos;
using MediatR;

namespace Application.Features.SendDatas.Queries.GetByDateRange;

public sealed record GetSendDataByDateRangeQuery(DateTime StartDate, DateTime EndDate)
    : IRequest<List<SendDataDto>>;
