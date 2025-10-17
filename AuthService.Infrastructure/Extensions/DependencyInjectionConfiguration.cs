using AuthService.Application.Interfaces.Auth;
using AuthService.Application.Interfaces.Files;
using AuthService.Application.Interfaces.Services;
using AuthService.Infrastructure.Implementations.Auth;
using AuthService.Infrastructure.Implementations.Files;
using AuthService.Infrastructure.Implementations.Services;
using AuthService.Infrastructure.Options;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Minio;
using Shared.Interfaces;

namespace AuthService.Infrastructure.Extensions;

public static class DependencyInjectionConfiguration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        var minioOptions = configuration.GetSection(nameof(MinioOptions)).Get<MinioOptions>();
        
        services.AddScoped<IPasswordHasher, PasswordHasher>();
        services.AddScoped<IJwtProvider, JwtProvider>();
        services.AddScoped<IPermissionService, PermissionService>();
        
        services.AddSingleton<IAuthorizationHandler, PermissionAuthorizationHandler>();

        services.AddMinio(options =>
            options.WithCredentials(minioOptions!.AccessKey, minioOptions.SecretKey)
                .WithEndpoint(minioOptions.Endpoint)
                .WithSSL()
                .Build());

        services.AddScoped<IBucketService, BucketService>();
        services.AddScoped<IFileService, FileService>();
        
        
        return services; 
    }
}