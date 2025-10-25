using System.Linq.Expressions;
using AuthService.Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AuthService.Persistence.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly AuthServiceDbContext _dbContext;

    public GenericRepository(AuthServiceDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public virtual async Task<List<T>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await _dbContext.Set<T>().ToListAsync(cancellationToken);
    }

    public virtual async Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _dbContext.Set<T>().FindAsync([id], cancellationToken);
    }

    public async Task<T?> GetByFilterAsync(Expression<Func<T, bool>> filter, CancellationToken cancellationToken = default)
    {
        return await _dbContext.Set<T>().FirstOrDefaultAsync(filter, cancellationToken);
    }

    public async Task CreateAsync(T entity, CancellationToken cancellationToken = default)
    {
        await _dbContext.Set<T>().AddAsync(entity, cancellationToken);
    }

    public void Update(T entity)
    {
        _dbContext.Set<T>().Update(entity);
    }

    public void Remove(T entity)
    {
        _dbContext.Set<T>().Remove(entity);
    }
}