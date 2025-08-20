using Microsoft.AspNetCore.Mvc;
using MvcShop.Services;

namespace MvcShop.Controllers;

public sealed class ProductsController(IProductRepository repo) : Controller
{
    public IActionResult Index()
    {
        var items = repo.GetAll()
                        .OrderBy(p => p.Name)
                        .ToList();
        return View(items);
    }

    public IActionResult Details(int id)
    {
        var product = repo.GetById(id);
        if (product is null) return NotFound();
        return View(product);
    }
}
