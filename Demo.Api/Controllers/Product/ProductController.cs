using Demo.Application.Commands.EmployeeCommands;
using Demo.Application.Commands.ProductCommand;
using Demo.Application.Queries.EmployeeQueries;
using Demo.Application.Queries.ProductQueries;
using Demo.Domain.Dtos.Employee;
using Demo.Domain.Dtos.Product;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Api.Controllers.Product
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(IMediator mediator) : ControllerBase
    {
        // Get all Products
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var result = await mediator.Send(new GetAllProductQuery());
            return Ok(result);
        }


        // Add a new product
        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductDto product)
        {
            var result = await mediator.Send(new CreateProductCommand(product));
            return Ok(result);
        }
    }
}
