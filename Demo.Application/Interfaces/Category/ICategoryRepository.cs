

using Demo.Domain.Dtos.Category;

namespace Demo.Application.Interfaces.Category
{
    public interface ICategoryRepository
    {
        Task<CategoryResponseDto> CreateCategory(CreateCategoryDto categoryDto, CancellationToken cancellationToken);
        Task<CategoryResponseDto> UpdateCategory(Guid id, UpdateCategoryDto categoryDto, CancellationToken cancellationToken);
        Task<List<CategoryResponseDto>> GetAllCategories(CancellationToken cancellationToken);
        Task<CategoryResponseDto> GetCategoryById(Guid id, CancellationToken cancellationToken);
        Task<bool> DeleteCategoryById(Guid id, CancellationToken cancellationToken);
    }
}
