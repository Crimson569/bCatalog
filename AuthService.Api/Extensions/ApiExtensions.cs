using System.Text;
using AuthService.Infrastructure.Options;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.IdentityModel.Tokens;

namespace AuthService.Api.Extensions;

public static class ApiExtensions
{
    public static IServiceCollection AddApiAuthentication(this IServiceCollection services, IConfiguration configuration)
    {
        var jwtOptions = configuration.GetSection("JwtOptions").Get<JwtOptions>();

        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtOptions.SecretKey))
                };
            });

        services.AddAuthorization();
        
        return services;
    }

    public static IServiceCollection AddApiCors(this IServiceCollection services)
    {
        services.AddCors(o =>
        {
            o.AddPolicy("PolicyAny", b =>
            {
                b.AllowAnyHeader();
                b.AllowAnyOrigin();
                b.AllowAnyMethod();
            });
        });
        
        return services;
    }
}