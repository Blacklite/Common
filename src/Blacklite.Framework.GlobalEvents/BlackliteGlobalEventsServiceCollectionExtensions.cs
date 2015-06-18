using Blacklite.Framework;
using Blacklite.Framework.GlobalEvents;

namespace Microsoft.Framework.DependencyInjection
{
    public static class GlobalEventsServiceCollectionExtensions
    {
        public static IServiceCollection AddGlobalEvents([NotNull] this IServiceCollection services)
        {
            services.TryAdd(GlobalEventsServices.GetDefaultServices());
            return services;
        }

    }
}
