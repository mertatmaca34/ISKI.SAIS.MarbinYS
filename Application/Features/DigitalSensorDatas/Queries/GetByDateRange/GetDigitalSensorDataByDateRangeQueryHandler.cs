using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Features.DigitalSensorDatas.Dtos;
using AutoMapper;
using Domain.Repositories;
using MediatR;

namespace Application.Features.DigitalSensorDatas.Queries.GetByDateRange;

public sealed class GetDigitalSensorDataByDateRangeQueryHandler(
    IDigitalSensorDataRepository repository,
    IMapper mapper) : IRequestHandler<GetDigitalSensorDataByDateRangeQuery, List<DigitalSensorDataDto>>
{
    public async Task<List<DigitalSensorDataDto>> Handle(GetDigitalSensorDataByDateRangeQuery request, CancellationToken cancellationToken)
    {
        var items = await repository.GetAllAsync(
            x => x.ReadTime >= request.StartDate && x.ReadTime < request.EndDate);

        return items
            .OrderBy(x => x.ReadTime)
            .ThenBy(x => x.Id)
            .Select(mapper.Map<DigitalSensorDataDto>)
            .ToList();
    }
}
