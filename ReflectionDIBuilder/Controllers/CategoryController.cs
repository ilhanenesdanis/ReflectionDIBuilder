using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReflectionDIBuilder.Abstract;

namespace ReflectionDIBuilder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _category;

        public CategoryController(ICategoryRepository category)
        {
            _category = category;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _category.GetAllCategory());
        }
    }
}
