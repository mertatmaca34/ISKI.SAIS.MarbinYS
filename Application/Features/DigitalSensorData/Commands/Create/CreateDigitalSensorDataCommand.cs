using Application.Features.DigitalSensorData.Dtos;
using MediatR;

namespace Application.Features.DigitalSensorData.Commands.Create;

public record CreateDigitalSensorDataCommand(
    DateTime ReadTime,
    bool Kapi,
    bool Duman,
    bool SuBaskini,
    bool AcilStop,
    bool Pompa1Termik,
    bool Pompa2Termik,
    bool TemizSuTermik,
    bool YikamaTanki,
    bool Enerji,
    bool Pompa1CalisiyorMu,
    bool Pompa2CalisiyorMu) : IRequest<DigitalSensorDataDto>;
