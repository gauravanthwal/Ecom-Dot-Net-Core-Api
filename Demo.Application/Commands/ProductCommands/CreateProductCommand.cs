using AutoMapper;
using Demo.Application.Interfaces.ProductRepository;
using Demo.Domain.Dtos.Product;
using MediatR;


namespace Demo.Application.Commands.ProductCommand
{
    public record CreateProductCommand(CreateProductDto product) : IRequest<ProductResponseDto>;

    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ProductResponseDto>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<ProductResponseDto> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            ProductResponseDto product = await _productRepository.CreateProduct(request.product, cancellationToken);
            return product;
        }
    }
}
