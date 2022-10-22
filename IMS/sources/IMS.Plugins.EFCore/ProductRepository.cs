using IMS.Domain;
using IMS.UseCases.PluginInterfaces;
using Microsoft.EntityFrameworkCore;

namespace IMS.Plugins.EFCore;

public class ProductRepository : IProductRepository
{
    private readonly IMSContext context;

    public ProductRepository(IMSContext context)
    {
        this.context = context;
    }
    public async Task<List<Product>> GetProductsByNameAsync(string name)
    {
        return await context.Products.Where(x => x.Name.Contains(name, StringComparison.OrdinalIgnoreCase) || 
            string.IsNullOrWhiteSpace(name)).ToListAsync();
    }
}
