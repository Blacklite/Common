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
        public static IEnumerable<IServiceDescriptor> GetApplicationEvents(IConfiguration configuration = null)
        {
            var describe = new ServiceDescriber(configuration);

            yield return describe.Singleton<IEventObservable, GlobalObservable>();
            yield return describe.Singleton<IEventOrchestrator, GlobalOrchestrator>();
        }
    }
}
