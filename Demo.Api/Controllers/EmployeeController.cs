using Demo.Application.Commands.EmployeeCommands;
using Demo.Application.Queries.EmployeeQueries;
using Demo.Domain.Dtos.Employee;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Api.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class EmployeeController(IMediator mediatr): ControllerBase
    {

        // Get all employees
        [HttpGet]
        public async Task<IActionResult> GetAllEmployee()
        {
            var result = await mediatr.Send(new GetAllEmployeeQuery());
            return Ok(result);
        }


        // Add a new employee
        [HttpPost]
        public async Task<IActionResult> AddEmployee([FromBody] EmployeeDto employee)
        {
            var result = await mediatr.Send(new AddEmployeeCommand(employee));
            return Ok(result);
        }
    }
}
