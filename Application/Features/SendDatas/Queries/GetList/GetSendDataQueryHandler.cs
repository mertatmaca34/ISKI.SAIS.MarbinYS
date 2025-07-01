using MediatR;
using AutoMapper;
using Infrastructure.Persistence.Abstract;
using Application.Features.SendDatas.Dtos;

namespace Application.Features.SendDatas.Queries.GetList;

public class GetSendDataQueryHandler(
    ISendDataRepository repository,
    IMapper mapper) : IRequestHandler<GetSendDataQuery, List<SendDataDto>>
{
    public async Task<List<SendDataDto>> Handle(GetSendDataQuery request, CancellationToken cancellationToken)
    {
        var items = await repository.GetAllAsync(x => true);
        return items.Select(mapper.Map<SendDataDto>).ToList();
    }
}
