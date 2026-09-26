using Demo.Application.Interfaces.Category;
using Demo.Domain.Dtos.Category;
using MediatR;

namespace Demo.Application.Commands.CategoryCommands
{
    public record CreateCategoryCommand(CreateCategoryDto categoryDto) : IRequest<CategoryResponseDto>;
    public class CreateCategoryCommandHandler(ICategoryRepository categoryRepository): IRequestHandler<CreateCategoryCommand, CategoryResponseDto>
    {
        public Task<CategoryResponseDto> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            return categoryRepository.CreateCategory(request.categoryDto, cancellationToken);
        }
    }
}
