using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace NetCore.Prototype.ApiVersioning.App.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApiVersions(this IServiceCollection services)
        {
            services.AddApiVersioning(apiVersioningOptions =>
            {
                apiVersioningOptions.AssumeDefaultVersionWhenUnspecified = true;
                apiVersioningOptions.DefaultApiVersion = new ApiVersion(1, 0);
                apiVersioningOptions.ReportApiVersions = true;
            });

            return services;
        }
    }
}
