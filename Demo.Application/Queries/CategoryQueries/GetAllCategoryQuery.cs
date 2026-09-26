using Demo.Application.Interfaces.Category;
using Demo.Domain.Dtos.Category;
using MediatR;

namespace Demo.Application.Queries.CategoryQueries
{
    public record GetAllCategoryQuery() : IRequest<List<CategoryResponseDto>>;
    public class GetAllCategoryQueryHandler(ICategoryRepository categoryRepository): IRequestHandler<GetAllCategoryQuery, List<CategoryResponseDto>>
    {
        public Task<List<CategoryResponseDto>> Handle(GetAllCategoryQuery request, CancellationToken cancellationToken)
        {
            return categoryRepository.GetAllCategories(cancellationToken);
        }
    }
}
