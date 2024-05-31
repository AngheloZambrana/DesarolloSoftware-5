using System.Linq.Expressions;
using api_dotnet.Entities;

public interface IBaseRepository<T>: IDisposable where T : IEntitiesBase, new ()
{
    Task<int> Create(T entity);
    Task<int> Update(T entity);
    Task<int> Delete(T entity);
    Task<IList<T>> Read(Expression<Func<T, bool>> lambda);
    Task<T> GetById(Guid id);
}