using Microsoft.AspNetCore.Mvc;
using MobilApp.API.Services;
using MobilApp.Entities;

namespace MobilApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerService _service;

        public CustomerController(CustomerService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var customers = _service.GetAllCustomers();
            return Ok(customers);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var customers = _service.GetCustomerById(id);
            if (customers == null)
            {
                return NotFound();
            }
            return Ok(customers);
        }

        [HttpPost]
        public IActionResult Add([FromBody] Customer customer)
        {
            if (customer == null)
            {
                return BadRequest();
            }
            _service.AddCustomer(customer);
            return Ok(new { message = "Customer added successfully" });
        }

        [HttpPut]
        public IActionResult Update([FromBody] Customer customer)
        {
            if (customer == null)
            {
                return BadRequest();
            }
            _service.AddCustomer(customer);
            return Ok(new { message = "Customer updated successfully" });
        }
    }
}
