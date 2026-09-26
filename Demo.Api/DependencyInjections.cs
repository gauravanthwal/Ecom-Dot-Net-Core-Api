using Demo.Application;
using Demo.Domain;
using Demo.Infrastructure;

namespace Demo.Api
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddApiDI(this IServiceCollection services, IConfiguration config)
        {
            services.AddDomainDI(config);
            services.AddApplicationDI();
            services.AddInfrastructureDI(config);
            return services;
        }
    }
}
