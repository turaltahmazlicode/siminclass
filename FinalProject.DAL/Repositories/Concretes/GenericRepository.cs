using FinalProject.DAL.Contexts;
using System.Linq.Expressions;

namespace FinalProject.DAL.Repositories.Concretes;
public class GenericRepository<T> : IGenericRepository<T> where T : class, new()
{
    public GenericRepository(AppDbContext context) => _context = context;

    private readonly AppDbContext _context;

    public DbSet<T> Table => _context.Set<T>();

    public IQueryable<T> FindAll()
    {
        return Table.AsQueryable();
    }

    public IQueryable<T>? FindByCondition(Expression<Func<T, bool>> expression)
    {
        return Table.AsQueryable().Where(expression);
    }

    public async Task<T?> FindByIdAsync(int id)
    {
        return await Table.FindAsync(id);
    }

    public async Task CreateAsync(T entity)
    {
        await Table.AddAsync(entity);
    }

    public void Delete(T entity)
    {
        Table.Remove(entity);
    }

    public void Update(T entity)
    {
        Table.Update(entity);
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}