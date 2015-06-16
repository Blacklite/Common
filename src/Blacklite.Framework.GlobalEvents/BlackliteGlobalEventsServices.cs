using Blacklite.Framework.Events;
using Microsoft.Framework.ConfigurationModel;
using Microsoft.Framework.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

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
