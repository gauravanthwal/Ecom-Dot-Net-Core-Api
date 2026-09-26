using Demo.Domain.Dtos.Product;
using Demo.Domain.Entities;

namespace Demo.Application.Interfaces.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<ProductResponseDto>> GetAllProducts(CancellationToken cancellationToken = default);

        Task<ProductResponseDto?> GetProductById(Guid id, CancellationToken cancellationToken = default);

        Task<ProductResponseDto> CreateProduct(CreateProductDto product, CancellationToken cancellationToken = default);

        Task<ProductResponseDto?> UpdateProduct(Guid id, UpdatedProductDto product, CancellationToken cancellationToken = default);

        Task<bool?> DeleteProductById(Guid id, CancellationToken cancellationToken = default);
    }
}
