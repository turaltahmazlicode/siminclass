using System.Linq.Expressions;

namespace FinalProject.DAL.Repositories.Abstractions;
public interface IGenericRepository<T> where T : class, new()
{
    DbSet<T> Table { get; }
    IQueryable<T> FindAll();
    IQueryable<T>? FindByCondition(Expression<Func<T, bool>> expression);
    Task<T?> FindByIdAsync(int id);
    Task CreateAsync(T entity);
    void Update(T entity);
    void Delete(T entity);
    Task SaveChangesAsync();
}
