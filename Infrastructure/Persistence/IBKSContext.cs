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

        modelBuilder.Entity<MailAlarm>().HasData(new MailAlarm
        {
            Id = 1,
            Name = "AKM Limit Aşımı",
            Channel = "AKM",
            Limit = 90,
            MailSubject = "AKM Limit Aşıldı",
            MailBody = "AKM limit aşıldı. Değer: {value}"
        });
    }
}
