using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence;

public class IBKSContext(DbContextOptions<IBKSContext> options) : DbContext(options)
{
    public DbSet<Log> Logs => Set<Log>();
    public DbSet<MailSetting> MailSettings => Set<MailSetting>();
    public DbSet<SendData> SendData => Set<SendData>();
    public DbSet<ApiEndpoint> ApiEndpoints => Set<ApiEndpoint>();
    public DbSet<CalibrationLimit> CalibrationLimits => Set<CalibrationLimit>();
    public DbSet<CalibrationMeasurement> CalibrationMeasurements => Set<CalibrationMeasurement>();
    public DbSet<DigitalSensorData> DigitalSensorData => Set<DigitalSensorData>();
    public DbSet<AnalogSensorData> AnalogSensorData => Set<AnalogSensorData>();
    public DbSet<PlcInformation> PlcInformations => Set<PlcInformation>();
    public DbSet<Station> Stations => Set<Station>();
    public DbSet<User> Users => Set<User>();
    public DbSet<MailAlarm> MailAlarms => Set<MailAlarm>();
    public DbSet<UserMailAlarm> UserMailAlarms => Set<UserMailAlarm>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(IBKSContext).Assembly);

        modelBuilder.Entity<MailSetting>().HasData(new MailSetting
        {
            Id = 1,
            SmtpHost = "10.0.3.63",
            SmtpPort = 25,
            SmtpUser = "sais@iski.istanbul",
            SmtpPassword = "Ss,2023",
            UseSsl = false,
            SenderEmail = "sais@iski.istanbul",
            SenderName = "sais",
            UseDefaultCredentials = true,
            CreatedAt = new DateTime(2025, 9, 15, 12, 24, 38, DateTimeKind.Utc).AddTicks(6790330)
        });

        modelBuilder.Entity<MailAlarm>().HasData(
            new MailAlarm
            {
                Id = 1,
                Name = "AKM Limit Aşımı",
                Channel = "Akm",
                Limit = 90,
                MailSubject = "AKM Limit Aşıldı",
                MailBody = "AKM limit aşıldı. Değer: {value}"
            },
            new MailAlarm
            {
                Id = 2,
                Name = "KOİ Limit Aşımı",
                Channel = "Koi",
                Limit = 0,
                MailSubject = "KOİ Limit Aşıldı",
                MailBody = "KOİ limit aşıldı. Değer: {value}"
            },
            new MailAlarm
            {
                Id = 3,
                Name = "Çözünmüş Oksijen Aralık Dışı",
                Channel = "CozunmusOksijen",
                Limit = 0,
                MailSubject = "Çözünmüş Oksijen Aralık Dışı",
                MailBody = "Çözünmüş oksijen aralık dışı. Değer: {value}"
            },
            new MailAlarm
            {
                Id = 4,
                Name = "İletkenlik Limit Aşımı",
                Channel = "Iletkenlik",
                Limit = 0,
                MailSubject = "İletkenlik Limit Aşıldı",
                MailBody = "İletkenlikte limit aşıldı. Değer: {value}"
            },
            new MailAlarm
            {
                Id = 5,
                Name = "Kabin Dumanı",
                Channel = "KabinDuman",
                Limit = 0,
                MailSubject = "Kabin Dumanı Tetiklendi",
                MailBody = "Kabin dumanı tetiklendi."
            },
            new MailAlarm
            {
                Id = 6,
                Name = "Kabin Su Baskını",
                Channel = "KabinSuBaskini",
                Limit = 0,
                MailSubject = "Kabin Su Baskını Algılandı",
                MailBody = "Kabin su baskını algılandı."
            },
            new MailAlarm
            {
                Id = 7,
                Name = "Kabin Acil Stop",
                Channel = "KabinAcilStopBasili",
                Limit = 0,
                MailSubject = "Kabin Acil Stop Basıldı",
                MailBody = "Kabin acil stop basıldı."
            },
            new MailAlarm
            {
                Id = 8,
                Name = "Pompa 1 Termik",
                Channel = "Pompa1Termik",
                Limit = 0,
                MailSubject = "Pompa 1 Termik Attı",
                MailBody = "Pompa 1 termik attı."
            },
            new MailAlarm
            {
                Id = 9,
                Name = "Pompa 2 Termik",
                Channel = "Pompa2Termik",
                Limit = 0,
                MailSubject = "Pompa 2 Termik Attı",
                MailBody = "Pompa 2 termik attı."
            },
            new MailAlarm
            {
                Id = 10,
                Name = "Pompa 3 Termik",
                Channel = "Pompa3Termik",
                Limit = 0,
                MailSubject = "Pompa 3 Termik Attı",
                MailBody = "Pompa 3 termik attı."
            },
            new MailAlarm
            {
                Id = 11,
                Name = "Kabin Enerji Yok",
                Channel = "KabinEnerjiYok",
                Limit = 0,
                MailSubject = "Kabin Enerjisi Kesildi",
                MailBody = "Kabin enerjisi kesildi."
            },
            new MailAlarm
            {
                Id = 12,
                Name = "Tank Dolu",
                Channel = "TankDolu",
                Limit = 0,
                MailSubject = "Tank Doldu",
                MailBody = "Tank doldu."
            },
            new MailAlarm
            {
                Id = 13,
                Name = "Pompa 1 Çalışıyor",
                Channel = "Pompa1Calisiyor",
                Limit = 0,
                MailSubject = "Pompa 1 Çalışıyor",
                MailBody = "Pompa 1 çalışıyor."
            },
            new MailAlarm
            {
                Id = 14,
                Name = "Pompa 2 Çalışıyor",
                Channel = "Pompa2Calisiyor",
                Limit = 0,
                MailSubject = "Pompa 2 Çalışıyor",
                MailBody = "Pompa 2 çalışıyor."
            },
            new MailAlarm
            {
                Id = 15,
                Name = "Pompa 3 Çalışıyor",
                Channel = "Pompa3Calisiyor",
                Limit = 0,
                MailSubject = "Pompa 3 Çalışıyor",
                MailBody = "Pompa 3 çalışıyor."
            },
            new MailAlarm
            {
                Id = 16,
                Name = "Kabin Kapı Açıldı",
                Channel = "KabinKapiAcildi",
                Limit = 0,
                MailSubject = "Kabin Kapısı Açıldı",
                MailBody = "Kabin kapısı açıldı."
            },
            new MailAlarm
            {
                Id = 17,
                Name = "Kabin Otomatik Mod",
                Channel = "KabinOto",
                Limit = 0,
                MailSubject = "Kabin Otomatik Moda Geçti",
                MailBody = "Kabin otomatik moda geçti."
            },
            new MailAlarm
            {
                Id = 18,
                Name = "Kabin Bakım Modu",
                Channel = "KabinBakim",
                Limit = 0,
                MailSubject = "Kabin Bakım Moduna Geçti",
                MailBody = "Kabin bakım moduna geçti."
            },
            new MailAlarm
            {
                Id = 19,
                Name = "Kabin Kalibrasyon",
                Channel = "KabinKalibrasyon",
                Limit = 0,
                MailSubject = "Kabin Kalibrasyonda",
                MailBody = "Kabin kalibrasyon modunda."
            },
            new MailAlarm
            {
                Id = 20,
                Name = "Kabin Haftalık Yıkamada",
                Channel = "KabinHaftalikYikamada",
                Limit = 0,
                MailSubject = "Kabin Haftalık Yıkamada",
                MailBody = "Kabin haftalık yıkamada."
            },
            new MailAlarm
            {
                Id = 21,
                Name = "Kabin Saatlik Yıkamada",
                Channel = "KabinSaatlikYikamada",
                Limit = 0,
                MailSubject = "Kabin Saatlik Yıkamada",
                MailBody = "Kabin saatlik yıkamada."
            },
            new MailAlarm
            {
                Id = 22,
                Name = "AKM Tetik",
                Channel = "AkmTetik",
                Limit = 0,
                MailSubject = "AKM Tetiklendi",
                MailBody = "AKM tetiklendi."
            },
            new MailAlarm
            {
                Id = 23,
                Name = "KOİ Tetik",
                Channel = "KoiTetik",
                Limit = 0,
                MailSubject = "KOİ Tetiklendi",
                MailBody = "KOİ tetiklendi."
            },
            new MailAlarm
            {
                Id = 24,
                Name = "pH Tetik",
                Channel = "PhTetik",
                Limit = 0,
                MailSubject = "pH Tetiklendi",
                MailBody = "pH tetiklendi."
            },
            new MailAlarm
            {
                Id = 25,
                Name = "Manuel Tetik",
                Channel = "ManuelTetik",
                Limit = 0,
                MailSubject = "Manuel Tetiklendi",
                MailBody = "Manuel tetikleme yapıldı."
            },
            new MailAlarm
            {
                Id = 26,
                Name = "Simülasyon Numune Tetik",
                Channel = "SimNumuneTetik",
                Limit = 0,
                MailSubject = "Simülasyon Numune Tetiklendi",
                MailBody = "Simülasyon numune tetiklendi."
            }
        );
    }
}
