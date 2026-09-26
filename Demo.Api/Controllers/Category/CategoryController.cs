using Demo.Application.Commands.CategoryCommands;
using Demo.Application.Commands.ProductCommand;
using Demo.Application.Queries.CategoryQueries;
using Demo.Application.Queries.ProductQueries;
using Demo.Domain.Dtos.Category;
using Demo.Domain.Dtos.Product;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Api.Controllers.Category
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController(IMediator mediator) : ControllerBase
    {
        // Get all Categories
        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var result = await mediator.Send(new GetAllCategoryQuery());
            return Ok(result);
        }


        // Add a new category
        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] CreateCategoryDto category)
        {
            var result = await mediator.Send(new CreateCategoryCommand(category));
            return Ok(result);
        }
    }
}
