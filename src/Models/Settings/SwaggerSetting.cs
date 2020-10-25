namespace ePizza.WebApi.Model
{
    using System;
    using Microsoft.OpenApi.Models;

    public class SwaggerSetting
    {
        public SwaggerSetting()
        {
            Name = "This is a new Restfull API for ePizza";
            Info = new OpenApiInfo
            {
                Title = "ePizza Service API",
                Description = "ePizza Service API - Test & Documentation Page, <a href='/swagger.yaml'>download swagger.yaml</a>",
                TermsOfService = new Uri("http://ompix.com/"),
                Contact = new OpenApiContact 
                {
                    Name = "Customer services",
                    Email = "help@ompix.net",
                    Url = new Uri("http://www.ompix.com/")
                },
                License = new OpenApiLicense
                {
                    Name = "Ompix. ® Derechos Reservados",
                    Url = new Uri("http://ompix.com/"),
                }
            };
            RoutePrefix = "docs";
        }

        public string Name { get; set; }

        public OpenApiInfo Info { get; set; }

        public string RoutePrefix { get; set; }
        
        public string RoutePrefixWithSlash =>
            string.IsNullOrWhiteSpace(RoutePrefix)
                ? string.Empty
                : RoutePrefix + "/";
    }
}
