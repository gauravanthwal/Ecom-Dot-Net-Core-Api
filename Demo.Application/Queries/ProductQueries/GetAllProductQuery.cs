using Demo.Application.Interfaces.ProductRepository;
using Demo.Domain.Dtos.Product;
using MediatR;

namespace Demo.Application.Queries.ProductQueries
{
    public record GetAllProductQuery() : IRequest<List<ProductResponseDto>>;
    public class GetAllProductQueryHandler(IProductRepository productRepository): IRequestHandler<GetAllProductQuery, List<ProductResponseDto>>
    {
        public Task<List<ProductResponseDto>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            return productRepository.GetAllProducts(cancellationToken);
        }
    }
}
