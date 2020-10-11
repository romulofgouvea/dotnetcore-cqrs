using cqrs.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace cqrs.Aplication.Configurations
{
    public static class DatabaseConfig
    {
        public static void AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddDbContext<CqrsContext>(options =>
                options.UseMySql(configuration.GetConnectionString("DefaultConnection")));

        }
    }
}
