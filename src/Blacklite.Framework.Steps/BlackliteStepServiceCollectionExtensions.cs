using Blacklite.Framework;
using Blacklite.Framework.Steps;
using Microsoft.Framework.ConfigurationModel;
using System;

namespace Microsoft.Framework.DependencyInjection
{
    public static class DomainProcessServiceCollectionExtensions
    {
        public static IServiceCollection AddStepServices(
            [NotNull] this IServiceCollection services,
            IConfiguration configuration = null)
        {
            ConfigureDefaultServices(services, configuration);
            services.TryAdd(BlackliteStepServices.GetDefaultServices(configuration));
            return services;
        }

        private static void ConfigureDefaultServices(IServiceCollection services, IConfiguration configuration)
        {
        }
    }
}
