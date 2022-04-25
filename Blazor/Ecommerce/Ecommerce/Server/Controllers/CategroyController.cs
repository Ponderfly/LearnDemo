using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Server.Controllers
{   
    [Route("api/[controller]")]
    [ApiController]
    public class CategroyController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategroyController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Category>>>> GetCategories()
        {
            var result = await _categoryService.GetCategories();
            return Ok(result);
        }
    }
}
