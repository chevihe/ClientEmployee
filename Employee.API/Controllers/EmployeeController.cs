using AutoMapper;
using Employee.API.PostModel;
using Employee.Core;
using Employee.Core.DTOs;
using Employee.Core.Entities;
using Employee.Core.Service;
using Employee.Servies;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Employee.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly IMapper _mapper;
       

        public EmployeeController(IEmployeeService employeeService, IMapper mapper)
        {
            _employeeService= employeeService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllActiveEmployees()
        {
            var employees = _employeeService.GetAllActiveEmployees();
           var list = employees.Select(l => _mapper.Map<EmployeeDto>(l));
            return Ok(list);
        }

        [HttpGet("arcive")]
        public IActionResult GetAllArchivesEmployees()
        {
            var employees = _employeeService.GetAllArcivesEmployees();
            var list = employees.Select(l => _mapper.Map<EmployeeDto>(l));
            return Ok(list);
        }

        [HttpPost]
        public IActionResult AddEmployee([FromBody]EmployeePostModel employee)
        {
           var _employee = _mapper.Map<Employee_>(employee);
            _employeeService.AddEmployee(_employee);
            return Ok(_employee);
        }

        // PUT: api/Employee/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id, [FromBody] EmployeePostModel employee)
        {
            var _employee=_mapper.Map<Employee_>(employee);
            return Ok(_employeeService.UpdateEmployee(id,_employee));
        }
        // DELETE: api/Employee/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var employee = _employeeService.GetEmployeeById(id);

            if (employee == null)
            {
                return NotFound();
            }

            _employeeService.DeleteAndRescueEmployee(id);
            return NoContent();
        }

    }
}