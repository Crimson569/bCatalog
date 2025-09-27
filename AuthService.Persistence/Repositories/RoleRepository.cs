using AuthService.Application.Interfaces.Repositories;
using AuthService.Domain.Entities;

namespace AuthService.Persistence.Repositories;

public class RoleRepository : GenericRepository<Role>, IRoleRepository
{
    private readonly AuthServiceDbContext _dbContext;
    
    public RoleRepository(AuthServiceDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }
}