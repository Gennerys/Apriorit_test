using EmployeeManagment.Data.Models;
using EmployeeManagment.Data.Repositories.Interfaces;
using EmployeeManagment.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {            
                var employees = _employeeRepository.Get(20, 0).Select(e => new EmployeeDto
                {
                    Name = e.Name,
                    Surname = e.Surname,
                    Salary = e.Salary,
                    PositionName = _employeeRepository.GetCurrentPosition(e.Id).Position.PositionName,
                    DateOfDissmisal = _employeeRepository.GetCurrentPosition(e.Id).DateOfDissmisal,
                    HireDate = _employeeRepository.GetCurrentPosition(e.Id).HireDate
      

                }).ToList();

                return Ok(employees);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var employee = _employeeRepository.Get(id);
                if (employee == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(employee);
                }
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }

        [HttpPost]
        public IActionResult Post(Employee employee)
        {
            try
            {
                _employeeRepository.Add(employee);
                return CreatedAtAction(nameof(Get), new { id = employee.Id }, employee);

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }
    }
}
