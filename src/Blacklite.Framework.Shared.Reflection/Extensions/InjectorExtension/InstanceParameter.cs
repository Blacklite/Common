using System;
using System.Reflection;

namespace Blacklite.Framework.Shared.Reflection.Extensions.InjectorExtension
{
    public class InstanceParameter : ConfiguredParameter
    {
        internal InstanceParameter(ParameterInfo parameterInfo, bool optional)
            : base(parameterInfo, optional)
        {
        }

        internal InstanceParameter(Type desiredType, Func<object, Func<ParameterInfo, bool>> predicate, bool optional = false)
            : base(null, optional)
        {
            TypeInfo = desiredType.GetTypeInfo();
            Predicate = predicate;
        }

        public TypeInfo TypeInfo { get; }
        public Func<object, Func<ParameterInfo, bool>> Predicate { get; }
    }
}
