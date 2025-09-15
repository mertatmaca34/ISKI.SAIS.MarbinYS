using Application.Features.DigitalSensorDatas.Dtos;
using MediatR;

namespace Application.Features.DigitalSensorDatas.Commands.Update;

public record UpdateDigitalSensorDataCommand(
    int Id,
    DateTime ReadTime,
    bool KabinOto,
    bool KabinBakim,
    bool KabinKalibrasyon,
    bool KabinDuman,
    bool KabinSuBaskini,
    bool KabinKapiAcildi,
    bool KabinEnerjiYok,
    bool KabinAcilStopBasili,
    bool KabinHaftalikYikamada,
    bool KabinSaatlikYikamada,
    bool Pompa1Termik,
    bool Pompa2Termik,
    bool Pompa3Termik,
    bool TankDolu,
    bool Pompa1Calisiyor,
    bool Pompa2Calisiyor,
    bool Pompa3Calisiyor,
    bool AkmTetik,
    bool KoiTetik,
    bool PhTetik,
    bool ManuelTetik,
    bool SimNumuneTetik) : IRequest<DigitalSensorDataDto>;
