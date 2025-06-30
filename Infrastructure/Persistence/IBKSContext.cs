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
    public DbSet<MailSettings> MailSettings => Set<MailSettings>();
    public DbSet<MailTrigger> MailTriggers  => Set<MailTrigger>();
    public DbSet<MailTriggerRecipient> MailTriggerRecipients => Set<MailTriggerRecipient>();
    public DbSet<MailUser> MailUsers => Set<MailUser>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(IBKSContext).Assembly);
    }
}
