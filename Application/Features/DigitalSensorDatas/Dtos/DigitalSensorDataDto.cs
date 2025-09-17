namespace Application.Features.DigitalSensorDatas.Dtos;

public class DigitalSensorDataDto
{
    public int Id { get; set; }
    public DateTime ReadTime { get; set; }
    public bool KabinOto { get; set; }
    public bool KabinBakim { get; set; }
    public bool KabinKalibrasyon { get; set; }
    public bool KabinDuman { get; set; }
    public bool KabinSuBaskini { get; set; }
    public bool KabinKapiAcildi { get; set; }
    public bool KabinEnerjiYok { get; set; }
    public bool KabinAcilStopBasili { get; set; }
    public bool KabinHaftalikYikamada { get; set; }
    public bool KabinSaatlikYikamada { get; set; }
    public bool Pompa1Termik { get; set; }
    public bool Pompa2Termik { get; set; }
    public bool Pompa3Termik { get; set; }
    public bool TankDolu { get; set; }
    public bool Pompa1Calisiyor { get; set; }
    public bool Pompa2Calisiyor { get; set; }
    public bool Pompa3Calisiyor { get; set; }
    public bool AkmTetik { get; set; }
    public bool KoiTetik { get; set; }
    public bool PhTetik { get; set; }
    public bool ManuelTetik { get; set; }
    public bool SimNumuneTetik { get; set; }
    public bool AkmMail { get; set; }
    public bool KoiMail { get; set; }
    public bool PhMail { get; set; }
}
