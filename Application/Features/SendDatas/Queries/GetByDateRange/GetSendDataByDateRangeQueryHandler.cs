using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Features.SendDatas.Dtos;
using AutoMapper;
using Domain.Repositories;
using MediatR;

namespace Application.Features.SendDatas.Queries.GetByDateRange;

public sealed class GetSendDataByDateRangeQueryHandler(
    ISendDataRepository repository,
    IMapper mapper) : IRequestHandler<GetSendDataByDateRangeQuery, List<SendDataDto>>
{
    public async Task<List<SendDataDto>> Handle(GetSendDataByDateRangeQuery request, CancellationToken cancellationToken)
    {
        var items = await repository.GetAllAsync(
            x => x.Readtime >= request.StartDate && x.Readtime < request.EndDate);

        return items
            .OrderBy(x => x.Readtime)
            .ThenBy(x => x.Id)
            .Select(mapper.Map<SendDataDto>)
            .ToList();
    }
}
