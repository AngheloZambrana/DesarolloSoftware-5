

using System.Linq.Expressions;
using api_dotnet.Entities;
using Microsoft.EntityFrameworkCore;

namespace api_dotnet.Repositories.Concretes;

public abstract class BaseRepository<T> : IBaseRepository<T> where T : class, IEntitiesBase, new()
{
    protected readonly PostgresContext context;

    protected BaseRepository(PostgresContext context)
    {
        this.context = context;
    }
    
    public void Dispose()
    {
        context.Dispose();
    }

    public async Task<int> Create(T entity)
    {
        context.Set<T>().Add(entity);
        return await context.SaveChangesAsync();
    }

    public Task<int> Update(T entity)
    {//tarea para la casa
        throw new NotImplementedException();
    }

    public async Task<int> Delete(T entity)
    {
        context.Set<T>().Remove(entity);
        return await context.SaveChangesAsync();
    }

    public async Task<IList<T>> Read(Expression<Func<T, bool>> lambda)
    {
        lambda.Compile();
        return await context.Set<T>().Where(lambda).ToListAsync();
    }

    public async Task<T> GetById(Guid id)
    {
        var response = await context.Set<T>().FirstAsync(t => t.Id.Equals(id));
        return response;
    }
}