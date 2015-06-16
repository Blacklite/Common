using Microsoft.Framework.DependencyInjection;

namespace Blacklite.Framework.Steps
{
    public static class BlackliteStepServices
    {
        public static IServiceCollection GetDefaultServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton(typeof(IStepProvider<,>), typeof(StepProvider<,>));
            services.AddTransient(typeof(IStepCache<,>), typeof(DefaultStepCache<,>));

            services.AddSingleton(typeof(IPhasedStepProvider<,>), typeof(PhasedStepProvider<,>));
            services.AddTransient(typeof(IPhasedStepCache<,>), typeof(DefaultPhasedStepCache<,>));

            return services;
        }
    }
}
