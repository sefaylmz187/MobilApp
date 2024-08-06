using Microsoft.AspNetCore.Mvc;
using MobilApp.API.Services;
using MobilApp.Entities;

namespace MobilApp.API.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
    public class GroupController : ControllerBase
     {
            private readonly GroupService _service;

            public GroupController(GroupService service)
            {
                _service = service;
            }

            [HttpGet]
            public IActionResult GetAll()
            {
                var groups = _service.GetAllGroups();
                return Ok(groups);
            }

            [HttpGet("{id}")]
            public IActionResult GetById(int id)
            {
                var group = _service.GetGroupById(id);
                if (group == null)
                {
                    return NotFound();
                }
                return Ok(group);
            }

            [HttpPost]
            public IActionResult Add([FromBody] Groups group)
            {
                if (group == null)
                {
                    return BadRequest();
                }
                _service.AddGroup(group);
                return Ok(new { message = "Group added successfully" });
            }
     }
}
