namespace ePizza.WebApi.Extension
{
    using AutoMapper;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Options;
    using Swashbuckle.AspNetCore.Swagger;
    using Swashbuckle.AspNetCore.SwaggerUI;
    using Swashbuckle.AspNetCore.SwaggerGen;
    using ePizza.WebApi.Infraestructure;
    using Microsoft.EntityFrameworkCore;
    using ePizza.WebApi.Common.Utility;
    using ePizza.WebApi.Service;

    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddServiceConfiguration(this IServiceCollection services)
        {
            return services
                ;
        }

        public static IServiceCollection AddRepositoryConfiguration(this IServiceCollection services)
        {
            return services
                .AddTransient<IPizzaSpecialService, PizzaSpecialService>()
                .AddTransient<IToppingService, ToppingService>();
        }

        public static IServiceCollection AddModelConfiguration(this IServiceCollection services)
        {
            return services            
                .AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }

        public static IServiceCollection AddDbConnectionAndProvider(this IServiceCollection services, IConfiguration configuration)
        {           
            return services
                .AddDbContext<InfraestructureContext>(options => options.UseSqlServer(configuration.GetConnectionString(Connections.SqlServer)));
        }

        public static IServiceCollection AddApiVersionWithExplorer(this IServiceCollection services)
        {
            return services
                .AddVersionedApiExplorer(options =>
                {
                    options.GroupNameFormat = "'v'VVV";
                    options.SubstituteApiVersionInUrl = true;
                })
                .AddApiVersioning(options =>
                {
                    options.AssumeDefaultVersionWhenUnspecified = true;
                    options.ReportApiVersions = true;
                    options.DefaultApiVersion = new ApiVersion(2, 1);
                });
        }

        public static IServiceCollection AddSwaggerOptions(this IServiceCollection services)
        {
            return services
                .AddTransient<IConfigureOptions<SwaggerOptions>, ConfigureSwaggerOptions>()
                .AddTransient<IConfigureOptions<SwaggerUIOptions>, ConfigureSwaggerUIOptions>()
                .AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerGenOptions>();
        }
    }
}
