using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Minio;
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
    
    public Task InitializeAsync()
    {
        throw new NotImplementedException();
    }

    public Task DisposeAsync()
    {
        throw new NotImplementedException();
    }

    private IServiceScope _scope = null!;
    private IMinioClient _minioClient = null!;
}