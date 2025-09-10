namespace Domain.Enums;

/// <summary>
/// Temel durum kodları for measurement channels.
/// </summary>
public enum SensorStatusCode
{
    /// <summary>Veri toplama ve kayıt sistemi çalışmıyor.</summary>
    VeriYok = 0,

    /// <summary>Geçerli ölçüm verisi (%80 geçerli veri koşulu sağlanmış).</summary>
    VeriGecerli = 1,

    /// <summary>Ölçüm verisi geçersiz. Ölçüm kanalında alarm var.</summary>
    Gecersiz = 4,

    /// <summary>Kalibrasyon uyarı eşiği aşıldı. 5 tekrar sonrası KalHatasi koduna geçer.</summary>
    KalLimitDisi = 7,

    /// <summary>Cihaz ile iletişim yok veya veri gelmiyor.</summary>
    IletisimHatasi = 8,

    /// <summary>Analizör kalibrasyonda.</summary>
    SistemKal = 9,

    /// <summary>Ölçümü etkileyen alarm, diğer kodlarla eşleşmiyorsa kullanılır.</summary>
    Alarm = 12,

    /// <summary>Cihaz purge modunda.</summary>
    Purge = 15,

    /// <summary>Kalibrasyon hatası. Sonraki kalibrasyona kadar sabit kalır.</summary>
    KalHatasi = 19,

    /// <summary>Akış ölçerde hata.</summary>
    AkisYok = 21,

    /// <summary>Deşarj yapılmıyor.</summary>
    DesarjYok = 22,

    /// <summary>Günlük yıkama sırasında.</summary>
    Yikama = 23,

    /// <summary>Haftalık yıkama sırasında.</summary>
    HaftalikYikama = 24,

    /// <summary>İstasyon bakımda.</summary>
    IstasyonBakimda = 25,

    /// <summary>Tesis bakımda.</summary>
    TesisBakimda = 26,

    /// <summary>Cihaz bakımda.</summary>
    CihazBakimda = 30,

    /// <summary>Debide arıza var.</summary>
    DebiArizasi = 31,

    /// <summary>1. nokta kalibrasyonu.</summary>
    Nokta1Kalibrasyon = 35,

    /// <summary>2. nokta kalibrasyonu.</summary>
    Nokta2Kalibrasyon = 36,

    /// <summary>Ölçüm cihaz aralığı dışında.</summary>
    OlcumAraligiDisinda = 39
}
