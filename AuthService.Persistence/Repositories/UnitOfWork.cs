using AuthService.Application.Interfaces.Repositories;

namespace AuthService.Persistence.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AuthServiceDbContext _dbContext;

    public UnitOfWork(AuthServiceDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        await _dbContext.SaveChangesAsync(cancellationToken);
    }
}