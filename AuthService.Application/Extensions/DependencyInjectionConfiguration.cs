using Microsoft.Extensions.DependencyInjection;

namespace AuthService.Application.Extensions;

public static class DependencyInjectionConfiguration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(DependencyInjectionConfiguration).Assembly));
        services.AddAutoMapper(typeof(DependencyInjectionConfiguration).Assembly);

        return services;
    }
}