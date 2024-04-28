using Microsoft.OpenApi.Models;

namespace LeoStore.Identidade.Api.Configurations
{
    public static class SwaggerConfig
    {
        public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "LeoStore Identity API",
                    Description = "Esta API faz parte do projeto LeoStore",
                    Contact = new OpenApiContact { Name = "Leonardo R Sousa", Email = "leo@email.com" },
                    License = new OpenApiLicense { Name = "MIT", Url = new Uri("https://opensource.org/licenses/MIT") }
                });
            });
            return services;
        }
    }
}
