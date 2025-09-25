using Application.Features.SendDatas.Dtos;
using MediatR;

namespace Application.Features.SendDatas.Commands.Update;

public class UpdateSendDataStatusCommand : IRequest<SendDataDto?>
{
    public int Id { get; set; }
    public bool? IsSent { get; set; }
    public bool SaatlikYikamaGecersiz { get; set; }
    public bool HaftalikYikamaGecersiz { get; set; }
    public bool KalibrasyonGecersiz { get; set; }
    public bool AkisHiziGecersiz { get; set; }
    public bool GecersizDebi { get; set; }
    public bool TekrarVeriGecersiz { get; set; }
    public bool GecersizOlcumBirimi { get; set; }
}
