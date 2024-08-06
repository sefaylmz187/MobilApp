using Microsoft.AspNetCore.Mvc;
using MobilApp.API.Services;
using MobilApp.Entities;

namespace MobilApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _service;

        public ProductController(ProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _service.GetAllProducts();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var products = _service.GetProductById(id);
            if (products == null)
            {
                return NotFound();
            }
            return Ok(products);
        }

        [HttpPost]
        public IActionResult Add([FromBody] Products product)
        {
            if (product == null)
            {
                return BadRequest();
            }
            _service.AddProduct(product);
            return Ok(new { message = "Product added successfully" });
        }

        [HttpPut]
        public IActionResult Update([FromBody] Products product)
        {
            if (product == null)
            {
                return BadRequest();
            }
            _service.AddProduct(product);
            return Ok(new { message = "Product updated successfully" });
        }
    }
}
