using Blacklite.Framework.Events;
using Microsoft.Framework.DependencyInjection;

namespace Blacklite.Framework.GlobalEvents
{
    public static class GlobalEventsServices
    {
        public static IServiceCollection GetDefaultServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton<IEventObservable<IGlobalEvent>, GlobalObservable>();

            return services;
        }
    }
}
