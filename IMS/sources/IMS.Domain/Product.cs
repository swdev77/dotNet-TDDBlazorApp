using System.ComponentModel.DataAnnotations;

namespace IMS.Domain;

public class Product
{
    public Product()
    {

    }
    public Product(int id, string name, int quantiry, double price)
    {
        Id = id;
        Name = name;
        Quantity = quantiry;
        Price = price;
    }

    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    [Range(0, int.MaxValue)]
    public int Quantity { get; set; }
    [Range(0, double.MaxValue)]
    public double Price { get; set; }
}
