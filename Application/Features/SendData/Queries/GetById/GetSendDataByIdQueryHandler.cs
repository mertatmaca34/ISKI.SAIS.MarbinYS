using MediatR;
using Application.Features.SendData.Dtos;
using Application.Services.Repositories;
using AutoMapper;

namespace Application.Features.SendData.Queries.GetById;

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
