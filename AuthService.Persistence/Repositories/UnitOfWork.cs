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
        await using var transaction = await _dbContext.Database.BeginTransactionAsync(cancellationToken);

        try
        {
            await _dbContext.SaveChangesAsync(cancellationToken);
            await transaction.CommitAsync(cancellationToken);
        }
        catch
        {
            await transaction.RollbackAsync(cancellationToken);
            throw;
        }
    }
}