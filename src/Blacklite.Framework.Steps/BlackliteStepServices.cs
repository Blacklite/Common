using Blacklite.Framework.Steps;
using Microsoft.Framework.ConfigurationModel;
using Microsoft.Framework.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Blacklite.Framework.Steps
{
    public static class BlackliteStepServices
    {
        public static IEnumerable<IServiceDescriptor> GetDefaultServices(IConfiguration configuration = null)
        {
            var describe = new ServiceDescriber(configuration);

            yield return describe.Singleton(typeof(IStepProvider<,>), typeof(StepProvider<,>));
            yield return describe.Transient(typeof(IStepCache<,>), typeof(StepCache<,>));

            yield return describe.Singleton(typeof(IPhasedStepProvider<,>), typeof(PhasedStepProvider<,>));
            yield return describe.Transient(typeof(IPhasedStepCache<,>), typeof(PhasedStepCache<,>));
        }
    }
}
