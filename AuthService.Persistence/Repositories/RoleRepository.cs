using AuthService.Application.Interfaces.Repositories;
using AuthService.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuthService.Persistence.Repositories;

public class RoleRepository : GenericRepository<Role>, IRoleRepository
{
    private readonly AuthServiceDbContext _dbContext;
    
    public RoleRepository(AuthServiceDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public override async Task<List<Role>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var roles = await _dbContext.Roles.Include(r => r.Permissions).ToListAsync(cancellationToken);
        return roles;
    }

    public override async Task<Role?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var role = await _dbContext.Roles.Include(r => r.Permissions)
            .FirstOrDefaultAsync(r => r.Id == id, cancellationToken);

        return role;
    }
}