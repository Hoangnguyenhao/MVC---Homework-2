using MvcShop.Models;

namespace MvcShop.Services;

public sealed class InMemoryProductRepository : IProductRepository
{
    private static readonly List<Product> _data =
    [
        new() { Id = 1, Name = "Keyboard TKL", Price = 990_000m },
        new() { Id = 2, Name = "Wireless Mouse", Price = 450_000m },
        new() { Id = 3, Name = "27\" Monitor", Price = 3_990_000m },
    ];

    public IReadOnlyList<Product> GetAll() => _data;
    public Product? GetById(int id) => _data.FirstOrDefault(p => p.Id == id);
}
