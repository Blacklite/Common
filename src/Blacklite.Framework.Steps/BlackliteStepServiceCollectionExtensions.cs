using Blacklite.Framework;
using Blacklite.Framework.Steps;

namespace Microsoft.Framework.DependencyInjection
{
    public static class DomainProcessServiceCollectionExtensions
    {
        public static IServiceCollection AddStepServices([NotNull] this IServiceCollection services)
        {
            ConfigureDefaultServices(services);
            services.TryAdd(BlackliteStepServices.GetDefaultServices());
            return services;
        }

        private static void ConfigureDefaultServices(IServiceCollection services)
        {
        }
    }
}
