using AutoMapper;
using Demo.Domain.Dtos.Category;
using Demo.Domain.Dtos.Product;
using Demo.Domain.Entities;

namespace Demo.Application.Features.Categories.Mappings
{
    public class CategoryMappingProfile: Profile
    {
        public CategoryMappingProfile()
        {
            // Entity -> Dto (for reads)
            CreateMap<ProductCategory, CategoryResponseDto>()
                .ForMember(dest => dest.ProductCount,
                    opt => opt.MapFrom(src => src.Products.Count));


            // Dto -> Entity (for writes)
            CreateMap<CreateCategoryDto, ProductCategory>();
            CreateMap<UpdateCategoryDto, ProductCategory>();
        }
    }
}
