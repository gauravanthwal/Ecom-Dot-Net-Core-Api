using Demo.Application.Features.Categories.Mappings;
using Demo.Application.Features.Products.Mappings;
using Microsoft.Extensions.DependencyInjection;

namespace Demo.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationDI(this IServiceCollection services)
        {
            services.AddAutoMapper(cfg => { }, typeof(ProductMappingProfile).Assembly);
            services.AddAutoMapper(cfg => { }, typeof(CategoryMappingProfile).Assembly);

            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly));

            return services;
        }
    }
}
