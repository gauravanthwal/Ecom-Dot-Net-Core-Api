using Demo.Application.Interfaces;
using Demo.Application.Interfaces.Category;
using Demo.Application.Interfaces.ProductRepository;
using Demo.Domain.Options;
using Demo.Infrastructure.Persistency;
using Demo.Infrastructure.Repositories;
using Demo.Infrastructure.Repositories.CategoryRepo;
using Demo.Infrastructure.Repositories.ProductRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Demo.Infrastructure
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<ConnectionStringOptions>(configuration.GetSection(ConnectionStringOptions.SectionName));

            services.AddDbContext<AppDbContext>((serviceProvider, options) =>
                options.UseNpgsql(serviceProvider.GetRequiredService<IOptionsMonitor<ConnectionStringOptions>>().CurrentValue.DefaultConnection)
            );

            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();

            return services;
        }
    }
}