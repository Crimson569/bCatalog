using AuthService.Infrastructure.Options;
using AuthService.Persistence;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Minio;
using Minio.AspNetCore;
using Testcontainers.Minio;
using Testcontainers.PostgreSql;

namespace AuthService.Integration.Helpers;

public class ApplicationFactory : WebApplicationFactory<Program>, IAsyncLifetime
{
    private const string DbUsername = "bcatalog";
    private const string DbPassword = "bcatalog_password";
    private const string DbName = "authservice";
    private const string PostgresImage = "postgres:latest";

    private const string MinioImage = "minio/minio:latest";
    private const string MinioUsername = "minio_user";
    private const string MinioPassword = "minio_password";
    
    private IServiceScope _scope = null!;
    private IMinioClient _minioClient = null!;
    public string _minioBucket = null!;

    public AuthServiceDbContext Context { get; private set; } = null!;
    public HttpClient HttpClient { get; private set; } = null!;
    
    private readonly PostgreSqlContainer _postgresContainer = new PostgreSqlBuilder()
        .WithImage(PostgresImage)
        .WithDatabase(DbName)
        .WithUsername(DbUsername)
        .WithPassword(DbPassword)
        .Build();

    private readonly MinioContainer _minioContainer = new MinioBuilder()
        .WithImage(MinioImage)
        .WithUsername(MinioUsername)
        .WithPassword(MinioPassword)
        .Build();
    
    public async Task InitializeAsync()
    {
        await Task.WhenAll(_postgresContainer.StartAsync(), _minioContainer.StartAsync());
        _scope = Services.CreateScope();

        _minioClient = _scope.ServiceProvider.GetRequiredService<IMinioClient>();
        _minioBucket = _scope.ServiceProvider.GetRequiredService<IOptions<BucketOptions>>().Value.Name;

        Context = _scope.ServiceProvider.GetRequiredService<AuthServiceDbContext>();

        HttpClient = CreateClient();

        await Context.Database.MigrateAsync();
    }

    public new async Task DisposeAsync()
    {
        await _postgresContainer.DisposeAsync();
        await _minioContainer.DisposeAsync();
    }
}