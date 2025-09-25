using System.Threading;
using System.Threading.Tasks;
using Application.Features.SendDatas.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Repositories;
using MediatR;

namespace Application.Features.SendDatas.Commands.Create;

public class CreateSendDataCommandHandler(
    ISendDataRepository repository,
    IMapper mapper
) : IRequestHandler<CreateSendDataCommand, SendDataDto>
{
    public async Task<SendDataDto> Handle(CreateSendDataCommand request, CancellationToken cancellationToken)
    {
        var existingEntity = await repository.GetAsync(
            x => x.Stationid == request.Stationid &&
                 x.Readtime == request.Readtime &&
                 x.DeletedAt == null);

        if (existingEntity is not null)
            return mapper.Map<SendDataDto>(existingEntity);

        var entity = new SendData
        {
            Stationid = request.Stationid,
            Readtime = request.Readtime,
            SoftwareVersion = request.SoftwareVersion,
            AkisHizi = request.AkisHizi,
            AKM = request.AKM,
            CozunmusOksijen = request.CozunmusOksijen,
            Debi = request.Debi,
            DesarjDebi = request.DesarjDebi,
            HariciDebi = request.HariciDebi,
            HariciDebi2 = request.HariciDebi2,
            KOi = request.KOi,
            pH = request.pH,
            Sicaklik = request.Sicaklik,
            Iletkenlik = request.Iletkenlik,
            Period = request.Period,
            AkisHizi_Status = request.AkisHizi_Status,
            AKM_Status = request.AKM_Status,
            CozunmusOksijen_Status = request.CozunmusOksijen_Status,
            Debi_Status = request.Debi_Status,
            DesarjDebi_Status = request.DesarjDebi_Status,
            HariciDebi_Status = request.HariciDebi_Status,
            HariciDebi2_Status = request.HariciDebi2_Status,
            KOi_Status = request.KOi_Status,
            pH_Status = request.pH_Status,
            Sicaklik_Status = request.Sicaklik_Status,
            Iletkenlik_Status = request.Iletkenlik_Status,
            IsSent = request.IsSent
        };

        await repository.AddAsync(entity);
        return mapper.Map<SendDataDto>(entity);
    }
}
