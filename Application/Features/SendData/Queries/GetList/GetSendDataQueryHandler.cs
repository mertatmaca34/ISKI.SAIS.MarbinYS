using MediatR;
using Application.Features.SendData.Dtos;
using Application.Services.Repositories;
using AutoMapper;

namespace Application.Features.SendData.Queries.GetList;

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
