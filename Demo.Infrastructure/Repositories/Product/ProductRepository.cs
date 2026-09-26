

using AutoMapper;
using Demo.Application.Interfaces.ProductRepository;
using Demo.Domain.Dtos.Product;
using Demo.Domain.Entities;
using Demo.Infrastructure.Persistency;
using Microsoft.EntityFrameworkCore;

namespace Demo.Infrastructure.Repositories.ProductRepository
{
    public class ProductRepository(AppDbContext context, IMapper _mapper) : IProductRepository
    {
        public async Task<ProductResponseDto> CreateProduct(CreateProductDto product, CancellationToken cancellationToken = default)
        {
            var pr = _mapper.Map<Product>(product);
            await context.Products.AddAsync(pr, cancellationToken);
            await context.SaveChangesAsync(cancellationToken);

            return _mapper.Map<ProductResponseDto>(pr);
        }

        public Task<bool?> DeleteProductById(Guid id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductResponseDto>> GetAllProducts(CancellationToken cancellationToken = default)
        {
            List<Product> products = await context.Products
                .Include(p => p.ProductCategory)
                .AsNoTracking()
                .ToListAsync(cancellationToken);

            return products.Select(p => _mapper.Map<ProductResponseDto>(p)).ToList();
        }

        public Task<ProductResponseDto?> GetProductById(Guid id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<ProductResponseDto?> UpdateProduct(Guid id, UpdatedProductDto request, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
