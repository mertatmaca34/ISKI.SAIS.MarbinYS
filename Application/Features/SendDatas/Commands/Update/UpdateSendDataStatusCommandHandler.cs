using System.Threading;
using System.Threading.Tasks;
using Application.Features.SendDatas.Dtos;
using AutoMapper;
using Domain.Repositories;
using MediatR;

namespace Application.Features.SendDatas.Commands.Update;

public class UpdateSendDataStatusCommandHandler(
    ISendDataRepository repository,
    IMapper mapper) : IRequestHandler<UpdateSendDataStatusCommand, SendDataDto?>
{
    public async Task<SendDataDto?> Handle(UpdateSendDataStatusCommand request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        if (entity is null)
            return null;

        entity.IsSent = request.IsSent;
        entity.SaatlikYikamaGecersiz = request.SaatlikYikamaGecersiz;
        entity.HaftalikYikamaGecersiz = request.HaftalikYikamaGecersiz;
        entity.KalibrasyonGecersiz = request.KalibrasyonGecersiz;
        entity.AkisHiziGecersiz = request.AkisHiziGecersiz;
        entity.GecersizDebi = request.GecersizDebi;
        entity.TekrarVeriGecersiz = request.TekrarVeriGecersiz;
        entity.GecersizOlcumBirimi = request.GecersizOlcumBirimi;

        var updated = await repository.UpdateAsync(entity);
        return mapper.Map<SendDataDto>(updated);
    }
}
