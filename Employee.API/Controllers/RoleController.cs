using AutoMapper;
using Employee.API.PostModel;
using Employee.Core.Entities;
using Employee.Core.Service;
using Employee.Servies;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Employee.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;
        private readonly IMapper _mapper;

        public RoleController(IRoleService roleServies, IMapper mapper)
        {
            _roleService = roleServies;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var roles = _roleService.GetAllRole();
            return Ok(roles);
        }

        [HttpPost]
        public IActionResult AddRole([FromBody]RolePostModel role)
        {
            var _role = _mapper.Map<Role>(role);
            _roleService.AddRole(_role);
            return Ok(_role);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] RolePostModel role)
        {
            var _role = _mapper.Map<Role>(role);
            _roleService.UpdateRole(id,_role);
            return Ok(_role);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var role = _roleService.GetRoleById(id);

            if (role == null)
            {
                return NotFound();
            }

            _roleService.DeleteRole(id);
            return NoContent();
        }
    }
}
