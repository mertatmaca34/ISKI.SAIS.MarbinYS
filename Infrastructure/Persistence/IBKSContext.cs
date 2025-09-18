using Domain.Entities;
using Domain.Enums;
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

        modelBuilder.Entity<ApiEndpoint>().HasData(new ApiEndpoint
        {
            Id = 1,
            ApiAddress = "http://172.17.15.4/",
            UserName = "istanbul_iski_uskudar",
            Password = "iskiist34",
            DataSendPeriodMinute = 1,
            ResendDataPeriodMinute = 48 * 60,
            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc)
        });

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
                Name = "Kabin Dumanı",
                Channel = "KabinDuman",
                Limit = 0,
                MailSubject = "Kabin Dumanı Algılandı",
                MailBody = "Kabin içerisinde duman algılandı. Lütfen kontrol ediniz."
            },
            new MailAlarm
            {
                Id = 2,
                Name = "Kabin Su Baskını",
                Channel = "KabinSuBaskini",
                Limit = 0,
                MailSubject = "Kabin Su Baskını Algılandı",
                MailBody = "Kabin içerisinde su baskını algılandı. Lütfen kontrol ediniz."
            },
            new MailAlarm
            {
                Id = 3,
                Name = "Kabin Acil Stop",
                Channel = "KabinAcilStopBasili",
                Limit = 0,
                MailSubject = "Kabin Acil Stop Basıldı",
                MailBody = "Kabin acil stop butonuna basıldı."
            },
            new MailAlarm
            {
                Id = 4,
                Name = "Pompa 1 Termik",
                Channel = "Pompa1Termik",
                Limit = 0,
                MailSubject = "Pompa 1 Termik Koruması Aktif",
                MailBody = "Pompa 1 için termik koruması devreye girdi."
            },
            new MailAlarm
            {
                Id = 5,
                Name = "Pompa 2 Termik",
                Channel = "Pompa2Termik",
                Limit = 0,
                MailSubject = "Pompa 2 Termik Koruması Aktif",
                MailBody = "Pompa 2 için termik koruması devreye girdi."
            },
            new MailAlarm
            {
                Id = 6,
                Name = "Pompa 3 Termik",
                Channel = "Pompa3Termik",
                Limit = 0,
                MailSubject = "Pompa 3 Termik Koruması Aktif",
                MailBody = "Pompa 3 için termik koruması devreye girdi."
            },
            new MailAlarm
            {
                Id = 7,
                Name = "Kabin Enerji Yok",
                Channel = "KabinEnerjiYok",
                Limit = 0,
                MailSubject = "Kabin Enerjisi Kesildi",
                MailBody = "Kabin enerji girişi kesildi."
            },
            new MailAlarm
            {
                Id = 8,
                Name = "Tank Boş",
                Channel = "TankDolu",
                Limit = 0,
                MailSubject = "Tank Boş Uyarısı",
                MailBody = "Tank seviyesi minimuma indi."
            },
            new MailAlarm
            {
                Id = 9,
                Name = "AKM Tetik",
                Channel = "AkmTetik",
                Limit = 0,
                MailSubject = "AKM Numune Tetiklendi",
                MailBody = "AKM parametresi limiti aştı, numune alma işlemi tetiklendi."
            },
            new MailAlarm
            {
                Id = 10,
                Name = "KOİ Tetik",
                Channel = "KoiTetik",
                Limit = 0,
                MailSubject = "KOİ Numune Tetiklendi",
                MailBody = "KOİ parametresi limiti aştı, numune alma işlemi tetiklendi."
            },
            new MailAlarm
            {
                Id = 11,
                Name = "pH Tetik",
                Channel = "PhTetik",
                Limit = 0,
                MailSubject = "pH Numune Tetiklendi",
                MailBody = "pH parametresi limiti aştı, numune alma işlemi tetiklendi."
            },
            new MailAlarm
            {
                Id = 12,
                Name = "Manuel Tetik",
                Channel = "ManuelTetik",
                Limit = 0,
                MailSubject = "Manuel Numune Tetiklendi",
                MailBody = "Manuel olarak numune tetiklemesi yapıldı.",
                TemplateType = MailTemplateType.Info
            },
            new MailAlarm
            {
                Id = 13,
                Name = "Sim Numune Tetik",
                Channel = "SimNumuneTetik",
                Limit = 0,
                MailSubject = "Sim Numune Tetiklendi",
                MailBody = "Sim tarafından numune tetiklemesi yapıldı.",
                TemplateType = MailTemplateType.Info
            },
            new MailAlarm
            {
                Id = 14,
                Name = "AKM Limit Aşımı",
                Channel = "AkmMail",
                Limit = 0,
                MailSubject = "AKM Limiti Aşıldı",
                MailBody = "AKM parametresi limit değerini aştı. Numune alma işlemi gerçekleştirildi.",
                TemplateType = MailTemplateType.Info
            },
            new MailAlarm
            {
                Id = 15,
                Name = "KOİ Limit Aşımı",
                Channel = "KoiMail",
                Limit = 0,
                MailSubject = "KOİ Limiti Aşıldı",
                MailBody = "KOİ parametresi limit değerini aştı. Numune alma işlemi gerçekleştirildi.",
                TemplateType = MailTemplateType.Info
            },
            new MailAlarm
            {
                Id = 16,
                Name = "pH Limit Aşımı",
                Channel = "PhMail",
                Limit = 0,
                MailSubject = "pH Limiti Aşıldı",
                MailBody = "pH parametresi limit değerini aştı. Numune alma işlemi gerçekleştirildi.",
                TemplateType = MailTemplateType.Info
            },
            new MailAlarm
            {
                Id = 17,
                Name = "Saatlik Yıkama Geçersiz",
                Channel = "SaatlikYikamaGecersiz",
                Limit = 0,
                MailSubject = "Saatlik Yıkama Geçersiz",
                MailBody = "Saatlik yıkama işlemi geçersiz olarak değerlendirildi."
            },
            new MailAlarm
            {
                Id = 18,
                Name = "Haftalık Yıkama Geçersiz",
                Channel = "HaftalikYikamaGecersiz",
                Limit = 0,
                MailSubject = "Haftalık Yıkama Geçersiz",
                MailBody = "Haftalık yıkama işlemi geçersiz olarak değerlendirildi."
            },
            new MailAlarm
            {
                Id = 19,
                Name = "Kalibrasyon Geçersiz",
                Channel = "KalibrasyonGecersiz",
                Limit = 0,
                MailSubject = "Kalibrasyon Geçersiz",
                MailBody = "Kalibrasyon işlemi geçersiz olarak değerlendirildi."
            },
            new MailAlarm
            {
                Id = 20,
                Name = "Akış Hızı Geçersiz",
                Channel = "AkisHiziGecersiz",
                Limit = 0,
                MailSubject = "Akış Hızı Geçersiz",
                MailBody = "Akış hızı değeri geçersiz olarak değerlendirildi."
            },
            new MailAlarm
            {
                Id = 21,
                Name = "Geçersiz Debi",
                Channel = "GecersizDebi",
                Limit = 0,
                MailSubject = "Geçersiz Debi",
                MailBody = "Debi ölçümü geçersiz olarak değerlendirildi."
            },
            new MailAlarm
            {
                Id = 22,
                Name = "Tekrar Veri Geçersiz",
                Channel = "TekrarVeriGecersiz",
                Limit = 0,
                MailSubject = "Tekrar Veri Geçersiz",
                MailBody = "Tekrar edilen veri geçersiz olarak değerlendirildi."
            },
            new MailAlarm
            {
                Id = 23,
                Name = "Geçersiz Ölçüm Birimi",
                Channel = "GecersizOlcumBirimi",
                Limit = 0,
                MailSubject = "Geçersiz Ölçüm Birimi",
                MailBody = "Ölçüm birimi geçersiz olarak değerlendirildi."
            }
        );
    }
}
