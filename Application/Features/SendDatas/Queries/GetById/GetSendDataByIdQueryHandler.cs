using MediatR;
using AutoMapper;
using Domain.Repositories;
using Application.Features.SendDatas.Dtos;

namespace Application.Features.SendDatas.Queries.GetById;

public class GetSendDataByIdQueryHandler(
    ISendDataRepository repository,
    IMapper mapper) : IRequestHandler<GetSendDataByIdQuery, SendDataDto?>
{
    public async Task<SendDataDto?> Handle(GetSendDataByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        if (entity is null)
            return null;
        return mapper.Map<SendDataDto>(entity);
    }
}
