namespace Application.Features.SendDatas.Dtos;

public class SendDataDto
{
    public int Id { get; set; }
    public Guid Stationid { get; set; }
    public DateTime Readtime { get; set; }
    public DateTime CreatedAt { get; set; }
    public string SoftwareVersion { get; set; }
    public double AkisHizi { get; set; }
    public double AKM { get; set; }
    public double CozunmusOksijen { get; set; }
    public double Debi { get; set; }
    public double? DesarjDebi { get; set; }
    public double? HariciDebi { get; set; }
    public double? HariciDebi2 { get; set; }
    public double KOi { get; set; }
    public double pH { get; set; }
    public double Sicaklik { get; set; }
    public double Iletkenlik { get; set; }
    public int Period { get; set; }
    public int AkisHizi_Status { get; set; }
    public int AKM_Status { get; set; }
    public int CozunmusOksijen_Status { get; set; }
    public int Debi_Status { get; set; }
    public int? DesarjDebi_Status { get; set; }
    public int? HariciDebi_Status { get; set; }
    public int? HariciDebi2_Status { get; set; }
    public int KOi_Status { get; set; }
    public int pH_Status { get; set; }
    public int Sicaklik_Status { get; set; }
    public string Iletkenlik_Status { get; set; }
    public bool? IsSent { get; set; }
    public bool SaatlikYikamaGecersiz { get; set; }
    public bool HaftalikYikamaGecersiz { get; set; }
    public bool KalibrasyonGecersiz { get; set; }
    public bool AkisHiziGecersiz { get; set; }
    public bool GecersizDebi { get; set; }
    public bool TekrarVeriGecersiz { get; set; }
    public bool GecersizOlcumBirimi { get; set; }
}
