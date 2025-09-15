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

        modelBuilder.Entity<MailAlarm>().HasData(
            new MailAlarm
            {
                Id = 1,
                Name = "AKM Limit Aşımı",
                Channel = "AKM",
                Limit = 90,
                MailSubject = "AKM Limit Aşıldı",
                MailBody = "AKM limit aşıldı. Değer: {value}"
            },
            new MailAlarm
            {
                Id = 2,
                Name = "KOİ Limit Aşımı",
                Channel = "KOI",
                Limit = 0,
                MailSubject = "KOİ Limit Aşıldı",
                MailBody = "KOİ limit aşıldı. Değer: {value}"
            },
            new MailAlarm
            {
                Id = 3,
                Name = "Çözünmüş Oksijen Aralık Dışı",
                Channel = "CO",
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
                Name = "Duman Alarmı",
                Channel = "Duman",
                Limit = 0,
                MailSubject = "Duman Alarmı Tetiklendi",
                MailBody = "Duman alarmı tetiklendi."
            },
            new MailAlarm
            {
                Id = 6,
                Name = "Su Baskını",
                Channel = "SuBaskini",
                Limit = 0,
                MailSubject = "Su Baskını Algılandı",
                MailBody = "Su baskını algılandı."
            },
            new MailAlarm
            {
                Id = 7,
                Name = "Acil Stop",
                Channel = "AcilStop",
                Limit = 0,
                MailSubject = "Acil Stop Aktif Edildi",
                MailBody = "Acil stop aktif edildi."
            },
            new MailAlarm
            {
                Id = 8,
                Name = "Pompa 1 Termik",
                Channel = "Pompa1",
                Limit = 0,
                MailSubject = "Pompa 1 Termik Attı",
                MailBody = "Pompa 1 termik attı."
            },
            new MailAlarm
            {
                Id = 9,
                Name = "Pompa 2 Termik",
                Channel = "Pompa2",
                Limit = 0,
                MailSubject = "Pompa 2 Termik Attı",
                MailBody = "Pompa 2 termik attı."
            },
            new MailAlarm
            {
                Id = 10,
                Name = "Temiz Su Pompası Termik",
                Channel = "TemizSuPompa",
                Limit = 0,
                MailSubject = "Temiz Su Pompası Termik Attı",
                MailBody = "Temiz su pompası termik attı."
            },
            new MailAlarm
            {
                Id = 11,
                Name = "Yıkama Tankında Su Yok",
                Channel = "YikamaTank",
                Limit = 0,
                MailSubject = "Yıkama Tankında Su Kalmadı",
                MailBody = "Yıkama tankında su kalmadı."
            },
            new MailAlarm
            {
                Id = 12,
                Name = "Kabin Enerjisi Kesildi",
                Channel = "KabinEnerjisi",
                Limit = 0,
                MailSubject = "Kabin Enerjisi Kesildi",
                MailBody = "Kabin enerjisi kesildi."
            },
            new MailAlarm
            {
                Id = 13,
                Name = "Numune Alımı Tetiklendi",
                Channel = "NumuneAlimi",
                Limit = 0,
                MailSubject = "Numune Alımı Tetiklendi",
                MailBody = "Numune alımı tetiklendi. Ölçüm seti: {value}"
            }
        );
    }
}
