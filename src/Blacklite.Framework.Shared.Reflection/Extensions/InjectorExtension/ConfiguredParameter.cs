using System;
using System.Reflection;

namespace Blacklite.Framework.Shared.Reflection.Extensions.InjectorExtension
{
    class ConfiguredParameter
    {
        internal ConfiguredParameter(ParameterInfo parameterInfo, bool optional)
        {
            ParameterInfo = parameterInfo;
            Optional = optional;
        }

        public ParameterInfo ParameterInfo { get; }

        public bool Optional { get; }
    }
}
