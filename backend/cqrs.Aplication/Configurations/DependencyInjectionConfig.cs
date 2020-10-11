using cqrs.Domain.Interfaces;
using cqrs.Infra.Data.Context;
using cqrs.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace cqrs.Aplication.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            // Infra - Data
            services.AddScoped<ICandidateRepository, CandidateRepository>();
            services.AddScoped<CqrsContext>();

        }
    }
}
