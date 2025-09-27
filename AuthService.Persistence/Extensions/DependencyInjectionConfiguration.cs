using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AuthService.Persistence.Extensions;

public static class DependencyInjectionConfiguration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<AuthServiceDbContext>((serviceProvider, options) =>
        {
            var config = serviceProvider.GetRequiredService<IConfiguration>();
            var connectionString = config.GetConnectionString("DefaultConnection");

            options.UseNpgsql(connectionString, npgsqlBuilder =>
            {
                npgsqlBuilder.MigrationsAssembly(typeof(AuthServiceDbContext).Assembly.GetName().Name);
            });
        });
        
        return services;
    }
}