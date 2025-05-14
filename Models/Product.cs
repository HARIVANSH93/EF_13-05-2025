namespace ef_product.Models;

public class Product
{
    public int Id { get; set; } // Primary Key
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Stock { get; set; }
}
