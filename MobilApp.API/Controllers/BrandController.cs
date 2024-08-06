using Microsoft.AspNetCore.Mvc;
using MobilApp.API.Services;
using MobilApp.Entities;

namespace MobilApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly BrandService _service;

        public BrandController(BrandService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var brands = _service.GetAllBrands();
            return Ok(brands);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var brands = _service.GetBrandsById(id);
            if (brands == null)
            {
                return NotFound();
            }
            return Ok(brands);
        }

        [HttpPost]
        public IActionResult Add([FromBody] Brands brand)
        {
            if (brand == null)
            {
                return BadRequest();
            }
            _service.AddBrand(brand);
            return Ok(new { message = "Brand added successfully" });
        }

        [HttpPut]
        public IActionResult Update([FromBody] Brands brand)
        {
            if (brand == null)
            {
                return BadRequest();
            }
            _service.AddBrand(brand);
            return Ok(new { message = "Brand updated successfully" });
        }
    }
}
