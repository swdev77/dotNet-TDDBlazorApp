using IMS.Domain;

namespace IMS.Plugins.EFCore;

public static class ProductList
{
    public static List<Product> Make() =>
        new()
        {
            new Product() { Id = 1, Name = "Gas Car", Price = 20000, Quantity = 1 },
            new Product() { Id = 2, Name = "Electric Car", Price = 40000, Quantity = 1 },
        };
}
