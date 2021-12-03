using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;

namespace TCC.Application.Rest.Configuration
{
    public static class SwaggerConfig
    {
        public static void AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(swagger =>
            {
                swagger.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "TCC Service Pais API",
                    Description = "API demonstrando utilização de REST para construção de serviços.",
                    Contact = new OpenApiContact { Name = "Julio da Silva Cruz"},
                    License = new OpenApiLicense { Name = "MIT", Url = new Uri("https://opensource.org") }
                });
            });
        }

        public static void UseSwaggerConfiguration(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(swagger => swagger.SwaggerEndpoint("/swagger/v1/swagger.json", "v1"));
        }
    }
}
