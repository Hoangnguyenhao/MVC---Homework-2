namespace MvcShop.Models;

public sealed class Product
{
    public int Id { get; init; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
}
