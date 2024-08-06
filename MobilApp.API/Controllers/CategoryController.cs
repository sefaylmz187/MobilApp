using Microsoft.AspNetCore.Mvc;
using MobilApp.API.Services;
using MobilApp.Entities;

namespace MobilApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly CategoryService _service;

        public CategoryController(CategoryService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var categories = _service.GetAllCategories();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var categories = _service.GetCategoryById(id);
            if (categories == null)
            {
                return NotFound();
            }
            return Ok(categories);
        }

        [HttpPost]
        public IActionResult Add([FromBody] Categories category)
        {
            if (category == null)
            {
                return BadRequest();
            }
            _service.AddCategory(category);
            return Ok(new { message = "Category added successfully" });
        }

        [HttpPut]
        public IActionResult Update([FromBody] Categories category)
        {
            if (category == null)
            {
                return BadRequest();
            }
            _service.AddCategory(category);
            return Ok(new { message = "Category updated successfully" });
        }
    }
}
