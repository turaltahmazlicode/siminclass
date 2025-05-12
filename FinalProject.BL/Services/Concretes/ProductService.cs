
using FinalProject.DAL.Repositories.Concretes;

namespace FinalProject.BL.Services.Concretes;
public class ProductService
{
    public ProductService(IGenericRepository<Product> productRepository) => _repository = productRepository;

    private readonly IGenericRepository<Product> _repository;

    public List<Product> FindAll()
    { return null; }
    public List<Product>? FindByCondition(Expression<Func<Product, bool>> expression)
    { return null; }
    public async Task<Product?> FindByIdAsync(int id)
    { return null; }
    public async Task CreateAsync(Product product)
    { }
    public void Update(Product product)
    { }
    public void Delete(Product product)
    { }
    public async Task SaveChangesAsync()
    { }
}
