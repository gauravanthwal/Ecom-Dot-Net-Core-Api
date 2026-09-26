using AutoMapper;
using Demo.Domain.Dtos.Product;
using Demo.Domain.Entities;


namespace Demo.Application.Features.Products.Mappings
{
    public class ProductMappingProfile: Profile
    {
        public ProductMappingProfile()
        {
            // Entity -> Dto (for reads)
            CreateMap<Product, ProductResponseDto>()
                .ForMember(dest => dest.ProductCategoryName, 
                    opt => opt.MapFrom(src => src.ProductCategory.Name));


            // Dto -> Entity (for writes)
            CreateMap<CreateProductDto, Product>();
            CreateMap<UpdatedProductDto, Product>();
        }
    }
}
