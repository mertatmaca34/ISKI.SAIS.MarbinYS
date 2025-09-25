using System.Threading;
using System.Threading.Tasks;
using Application.Features.SendDatas.Dtos;
using AutoMapper;
using Domain.Repositories;
using MediatR;

namespace Application.Features.SendDatas.Queries.GetByStationAndReadTime;

public sealed class GetSendDataByStationAndReadTimeQueryHandler(
    ISendDataRepository repository,
    IMapper mapper) : IRequestHandler<GetSendDataByStationAndReadTimeQuery, SendDataDto?>
{
    public async Task<SendDataDto?> Handle(GetSendDataByStationAndReadTimeQuery request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetAsync(x => x.Stationid == request.StationId && x.Readtime == request.Readtime);
        if (entity is null)
            return null;

        return mapper.Map<SendDataDto>(entity);
    }
}
