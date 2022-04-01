using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private static List<Product> Products = new()
    {
        new Product
        {
            Id = 1,
            Title = "aaa",
            Description = "aaa111",
            ImageUrl = "",
            Price = 9.99m,
        },
        new Product
        {
            Id = 2,
            Title = "bbb",
            Description = "bbb222",
            ImageUrl = "",
            Price = 7.99m,
        },
        new Product
        {
            Id = 3,
            Title = "ccc",
            Description = "ccc222",
            ImageUrl = "",
            Price = 6.99m,
        }
    };
    
    [HttpGet]
    public async Task<ActionResult<List<Product>>> GetProduct()
    {
        return Ok(Products);
    }
}