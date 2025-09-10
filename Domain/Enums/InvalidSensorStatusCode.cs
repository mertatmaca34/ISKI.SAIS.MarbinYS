namespace Domain.Enums;

/// <summary>
/// Geçersiz durum kodları.
/// </summary>
public enum InvalidSensorStatusCode
{
    /// <summary>Eksik/geçersiz yıkama bilgisi.</summary>
    GecersizYikama = 200,

    /// <summary>Eksik/geçersiz haftalık yıkama bilgisi.</summary>
    GecersizHaftalikYikama = 201,

    /// <summary>Eksik/geçersiz aylık kalibrasyon bilgisi.</summary>
    GecersizKalibrasyon = 202,

    /// <summary>Geçersiz akış hızı.</summary>
    GecersizAkisHizi = 203,

    /// <summary>Geçersiz debi değeri.</summary>
    GecersizDebi = 204,

    /// <summary>Mükerrer veri.</summary>
    TekrarVeri = 205,

    /// <summary>Uygunsuz ölçüm birimi.</summary>
    GecersizOlcumBirimi = 206
}
