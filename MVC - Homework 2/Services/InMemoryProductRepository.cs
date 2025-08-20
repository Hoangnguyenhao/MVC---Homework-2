using MvcShop.Models;

namespace MvcShop.Services;

public sealed class InMemoryProductRepository : IProductRepository
{
    private static readonly List<Product> _data =
    [
        new() { Id = 1, Name = "Nguyễn Văn A", Price = 1_200_000m },
        new() { Id = 2, Name = "Trần Thị B", Price = 850_000m },
        new() { Id = 3, Name = "Lê Văn C", Price = 2_500_000m },
        new() { Id = 4, Name = "Phạm Thị D", Price = 3_100_000m },
        new() { Id = 5, Name = "Hoàng Văn E", Price = 1_750_000m }
    ];

    public IReadOnlyList<Product> GetAll() => _data;

    public Product? GetById(int id) => _data.FirstOrDefault(p => p.Id == id);
}
