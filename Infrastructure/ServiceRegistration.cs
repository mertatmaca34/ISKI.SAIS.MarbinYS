using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Application.Services.Repositories;
using Infrastructure.Persistence.Repositories;
using Infrastructure.Persistence;

namespace Infrastructure;

public static class ServiceRegistration
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<IBKSContext>(options =>
            options.UseSqlServer(connectionString));

        services.AddScoped<IMailTriggerRepository, MailTriggerRepository>();

        return services;
    }
}
