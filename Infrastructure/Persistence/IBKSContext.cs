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
    public DbSet<MailLog> MailLogs => Set<MailLog>();
    public DbSet<MailSetting> MailSettings => Set<MailSetting>();
    public DbSet<MailTrigger> MailTriggers  => Set<MailTrigger>();
    public DbSet<MailTriggerRecipient> MailTriggerRecipients => Set<MailTriggerRecipient>();
    public DbSet<MailUser> MailUsers => Set<MailUser>();
    public DbSet<SendData> SendData => Set<SendData>();
    public DbSet<ApiEndpoint> ApiEndpoints => Set<ApiEndpoint>();
    public DbSet<CalibrationLimit> CalibrationLimits => Set<CalibrationLimit>();
    public DbSet<CalibrationMeasurement> CalibrationMeasurements => Set<CalibrationMeasurement>();
    public DbSet<DigitalSensorData> DigitalSensorData => Set<DigitalSensorData>();
    public DbSet<AnalogSensorData> AnalogSensorData => Set<AnalogSensorData>();
    public DbSet<PlcInformation> PlcInformations => Set<PlcInformation>();
    public DbSet<Station> Stations => Set<Station>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(IBKSContext).Assembly);
    }
}
