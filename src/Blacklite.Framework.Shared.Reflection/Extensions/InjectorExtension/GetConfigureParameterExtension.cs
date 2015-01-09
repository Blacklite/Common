using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Blacklite.Framework.Shared.Reflection.Extensions.InjectorExtension
{
    static class GetConfigureParameterExtension
    {
        internal static ConfiguredParameter GetConfigureParameter(this IDictionary<TypeInfo, ConfiguredParameter> resolvedConfiguredParameter, Type type, IEnumerable<ConfiguredParameter> configuredParameters)
        {
            var typeInfo = type?.GetTypeInfo();
            ConfiguredParameter configuredParam = null;
            if (typeInfo != null && !resolvedConfiguredParameter.TryGetValue(typeInfo, out configuredParam))
            {
                configuredParam = configuredParameters.SingleOrDefault(x => x.ParameterInfo.ParameterType.GetTypeInfo().IsAssignableFrom(typeInfo));
                resolvedConfiguredParameter.Add(typeInfo, configuredParam);
            }

            return configuredParam;
        }
    }
}
