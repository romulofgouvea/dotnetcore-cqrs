using cqrs.Aplication.Configurations;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace cqrs.Aplication
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            // Setting DBContexts
            services.AddDatabaseConfiguration(Configuration);

            //Mediator Config
            System.Reflection.Assembly assembly = AppDomain.CurrentDomain.Load("cqrs.Domain");
            services.AddMediatR(assembly);

            //Swagger Config
            services.AddSwaggerConfiguration();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(c =>
                c.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
            );

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("CQRS!!");
                });

                endpoints.MapControllers();
            });

            app.UseSwaggerSetup();
        }
    }
}
