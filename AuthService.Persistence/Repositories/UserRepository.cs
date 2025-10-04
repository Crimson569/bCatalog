using AuthService.Application.Interfaces.Repositories;
using AuthService.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuthService.Persistence.Repositories;

public class UserRepository : GenericRepository<User>, IUserRepository
{
    private readonly AuthServiceDbContext _dbContext;
    
    public UserRepository(AuthServiceDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public override async Task<List<User>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var users = await _dbContext.Users.Include(u => u.Roles).ToListAsync(cancellationToken);
        return users;
    }

    public override async Task<User?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var user = await _dbContext.Users.Include(u => u.Roles).FirstOrDefaultAsync(u => u.Id == id, cancellationToken);
        return user;
    }
}