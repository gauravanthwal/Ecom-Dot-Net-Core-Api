using AutoMapper;
using Demo.Application.Interfaces.Category;
using Demo.Domain.Dtos.Category;
using Demo.Domain.Entities;
using Demo.Infrastructure.Persistency;
using Microsoft.EntityFrameworkCore;


namespace Demo.Infrastructure.Repositories.CategoryRepo
{
    public class CategoryRepository(AppDbContext context, IMapper mapper) : ICategoryRepository
    {
        public async Task<CategoryResponseDto> CreateCategory(CreateCategoryDto categoryDto, CancellationToken cancellationToken)
        {
            ProductCategory pr = mapper.Map<ProductCategory>(categoryDto);
            context.ProductCategories.Add(pr);
            await context.SaveChangesAsync();

            return mapper.Map<CategoryResponseDto>(pr);
        }

        public Task<bool> DeleteCategoryById(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CategoryResponseDto>> GetAllCategories(CancellationToken cancellationToken)
        {
            List<ProductCategory> categories = await context.ProductCategories
                .AsNoTracking()
                .ToListAsync(cancellationToken);

            return categories.Select(c => mapper.Map<CategoryResponseDto>(c)).ToList();
        }

        public Task<CategoryResponseDto> GetCategoryById(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryResponseDto> UpdateCategory(Guid id, UpdateCategoryDto categoryDto, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
