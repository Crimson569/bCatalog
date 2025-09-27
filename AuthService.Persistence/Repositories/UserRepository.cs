using AuthService.Application.Interfaces.Repositories;
using AuthService.Domain.Entities;

namespace AuthService.Persistence.Repositories;

public class UserRepository : GenericRepository<User>, IUserRepository
{
    private readonly AuthServiceDbContext _dbContext;
    
    public UserRepository(AuthServiceDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }
}