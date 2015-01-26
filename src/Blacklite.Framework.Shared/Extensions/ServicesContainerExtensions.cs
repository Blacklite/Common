using Blacklite;
using Blacklite.Framework;
using Microsoft.Framework.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

// We're cheating here, so we don't have to have two different difference namespaces everywhere
namespace Microsoft.Framework.DependencyInjection
{
    public static class ServicesContainerExtensions
    {
        public static bool TryAddImplementation([NotNull] this IServiceCollection collection,
                                  [NotNull] IServiceDescriptor descriptor)
        {
            if (!collection.Any(d => d.ImplementationType == descriptor.ImplementationType))
            {
                collection.Add(descriptor);
                return true;
            }
            return false;
        }

        public static bool TryAddImplementation([NotNull] this IServiceCollection collection,
                                  [NotNull] IEnumerable<IServiceDescriptor> descriptors)
        {
            bool anyAdded = false;
            foreach (var d in descriptors)
            {
                anyAdded = collection.TryAddImplementation(d) || anyAdded;
            }
            return anyAdded;
        }
    }
}
