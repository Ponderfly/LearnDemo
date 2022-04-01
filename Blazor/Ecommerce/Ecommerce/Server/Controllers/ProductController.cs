using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Server.Controllers;

public class ProductController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}