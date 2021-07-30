using EmployeeCRUD.DAL.Models;
using EmployeeCRUD.DAL.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize (Roles ="Admin")]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeRepository _employees;

        public EmployeeController(IEmployeeRepository employees)
        {
            _employees = employees;
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetEmployees()
        {
            return Ok(_employees.GetEmployees());
        }

        [HttpGet]
        [Route("{Id}")]
        public IActionResult GetEmployeeById(int Id)
        {
            var employee = _employees.GetEmployee(Id);

            if(employee == null)
            {
                return NotFound("Employee Not Found");
            }
            return Ok(employee);
        }

        [HttpPost]
        [Route("AddEmployee")]
        public IActionResult AddEmployee([FromBody]Employee employee)
        {
            _employees.AddEmployee(employee);
            return Ok("Employee Deleted SuccessFully.");
        }

        [HttpDelete]
        [Route("DeleteEmployee/{Id}")]
        public IActionResult DeleteEmployee(int Id)
        {
            var emp = _employees.GetEmployee(Id);

            if(emp != null)
            {
                _employees.DeleteEmployee(emp);
                return Ok("Employee Deleted SuccessFully.");
            }
            return NotFound("Employee Not Found");
        }

        [HttpPut]
        [Route("UpdateEmployee")]
        public IActionResult UpdateEmployee(Employee employee)
        {
            var emp = _employees.GetEmployee(employee.Id);

            if (emp != null)
            {
                _employees.EditEmployee(employee);
                return Ok("Employee Updated SuccessFully.");
            }
            return NotFound("Employee Not Found");
        }
    }
}
