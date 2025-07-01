using Application.Features.DigitalSensorData.Dtos;
using MediatR;

namespace Application.Features.DigitalSensorData.Commands.Update;

public record UpdateDigitalSensorDataCommand(
    int Id,
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
