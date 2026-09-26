using Demo.Domain.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Demo.Domain
{
    public static class DependecyInjections
    {
        public static IServiceCollection AddDomainDI(this IServiceCollection services, IConfiguration config)
        {
            services.Configure<ConnectionStringOptions>(config.GetSection(ConnectionStringOptions.SectionName));
            return services;
        }
    }
}
