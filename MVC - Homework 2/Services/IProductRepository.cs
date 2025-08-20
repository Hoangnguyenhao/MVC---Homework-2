using MvcShop.Models;

namespace MvcShop.Services;

public interface IProductRepository
{
    IReadOnlyList<Product> GetAll();
    Product? GetById(int id);
}
