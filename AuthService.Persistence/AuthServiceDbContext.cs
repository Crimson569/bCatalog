using AuthService.Domain.Entities;
using AuthService.Persistence.Configurations.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace AuthService.Persistence;

public class AuthServiceDbContext : DbContext
{
    private readonly IOptions<AuthorizationOptions> _authOptions;
    public AuthServiceDbContext(DbContextOptions<AuthServiceDbContext> options, IOptions<AuthorizationOptions> authorizationOptions) : base(options)
    {
        _authOptions = authorizationOptions;
    }
    
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Permission> Permissions { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(typeof(AuthServiceDbContext).Assembly);

        builder.ApplyConfiguration(new RolePermissionConfiguration(_authOptions.Value));
    }
}