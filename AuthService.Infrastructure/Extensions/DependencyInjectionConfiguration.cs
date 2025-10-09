using AuthService.Application.Interfaces.Auth;
using AuthService.Application.Interfaces.Services;
using AuthService.Infrastructure.Implementations.Auth;
using AuthService.Infrastructure.Implementations.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AuthService.Infrastructure.Extensions;

public static class DependencyInjectionConfiguration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddScoped<IPasswordHasher, PasswordHasher>();
        services.AddScoped<IJwtProvider, JwtProvider>();
        services.AddScoped<IPermissionService, PermissionService>();
        
        return services;
    }
}