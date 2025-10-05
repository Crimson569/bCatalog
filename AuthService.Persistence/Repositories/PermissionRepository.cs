using AuthService.Application.Interfaces.Repositories;
using AuthService.Domain.Entities;

namespace AuthService.Persistence.Repositories;

public class PermissionRepository : GenericRepository<Permission>, IPermissionRepository
{
    private readonly AuthServiceDbContext _dbContext;
    
    public PermissionRepository(AuthServiceDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }
}