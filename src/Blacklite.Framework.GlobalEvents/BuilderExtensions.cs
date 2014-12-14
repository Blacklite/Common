using Blacklite.Framework.GlobalEvents;
using Microsoft.Framework.ConfigurationModel;
using System;

namespace Microsoft.Framework.DependencyInjection
{
    public static class TenantOnlyServiceCollectionExtensions
    {
        public static IServiceCollection AddMultitenancy(
            [NotNull] this IServiceCollection services,
            IConfiguration configuration = null)
        {
            services.TryAdd(GlobalEventsServices.GetDefaultServices(configuration));
            return services;
        }

    }
        public class BuilderExtensions
    {

    }
}
