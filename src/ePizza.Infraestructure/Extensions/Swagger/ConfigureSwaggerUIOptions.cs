namespace ePizza.WebApi.Extension
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Mvc.ApiExplorer;
    using Microsoft.Extensions.Options;
    using ePizza.WebApi.Model;
    using Swashbuckle.AspNetCore.SwaggerUI;

    public sealed class ConfigureSwaggerUIOptions : IConfigureOptions<SwaggerUIOptions>
    {
        private readonly SwaggerSetting _settings;
        private readonly IApiVersionDescriptionProvider _provider;

        public ConfigureSwaggerUIOptions(IOptions<SwaggerSetting> settings, IApiVersionDescriptionProvider service)
        {
            Debug.Assert(settings != null, $"{nameof(service)} != null");
            Debug.Assert(service != null, $"{nameof(service)} != null");

            this._settings = settings?.Value ?? new SwaggerSetting();
            this._provider = service ?? throw new ArgumentNullException(nameof(service));
        }

        public void Configure(SwaggerUIOptions options)
        {
            _provider
                .ApiVersionDescriptions
                .ToList()
                .ForEach(description =>
                {
                    options.SwaggerEndpoint(
                        $"/{_settings.RoutePrefixWithSlash}{description.GroupName}/swagger.json",
                        $"API Process. {description.GroupName.ToUpperInvariant()}");

                    options.RoutePrefix = _settings.RoutePrefix;
                });
                options.DocumentTitle = "API Documentation";
        }
    }
}
