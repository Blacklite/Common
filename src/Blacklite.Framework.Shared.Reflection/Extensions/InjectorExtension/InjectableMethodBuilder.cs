using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Blacklite.Framework.Shared.Reflection.Extensions.InjectorExtension
{
    public partial class InjectableMethodBuilder
    {
        internal readonly MethodInfo _methodInfo;
        internal readonly IEnumerable<ParameterInfo> _parameterInfos;
        internal InstanceParameter _instanceParameter;
        internal readonly IList<ConfiguredParameter> _configuredParameters = new List<ConfiguredParameter>();
        internal readonly IList<Type> _returnTypes;

        internal InjectableMethodBuilder(MethodInfo methodInfo)
        {
            _methodInfo = methodInfo;
            _parameterInfos = methodInfo.GetParameters();
            _returnTypes = new List<Type>();
        }

        protected InjectableMethodBuilder(InjectableMethodBuilder builder)
        {
            _methodInfo = builder._methodInfo;
            _parameterInfos = builder._parameterInfos;
            _configuredParameters = builder._configuredParameters.ToList();
            _returnTypes = builder._returnTypes.ToList();
            _instanceParameter = builder._instanceParameter;
        }

        public InjectableMethodBuilder ConfigureParameter(Func<ParameterInfo, bool> predicate, bool optional = false)
        {
            // lack of optional means its required.
            var param = _parameterInfos.SingleOrDefault(predicate);
            if (param == null && !optional)
            {
                throw new MissingMemberException(string.Format("Could not find injectable property for predicate '{0}'", predicate));
            }

            if (param != null)
                _configuredParameters.Add(new ConfiguredParameter(param, optional));

            return new InjectableMethodBuilder(this);
        }

        public InjectableMethodBuilder ConfigureParameter(Type type, bool optional = false)
        {
            // lack of optional means its required.
            var param = _parameterInfos.SingleOrDefault(x => x.ParameterType.Equals(type));
            if (param == null && !optional)
            {
                throw new MissingMemberException(string.Format("Could not find injectable property for type '{0}'", type.FullName));
            }

            if (param != null)
                _configuredParameters.Add(new ConfiguredParameter(param, optional));

            return new InjectableMethodBuilder(this);
        }

        public InjectableMethodBuilder ConfigureInstanceParameter(Type type, Func<object, Func<ParameterInfo, bool>> predicate, bool optional = false)
        {
            // lack of optional means its required.
            var param = _parameterInfos.SingleOrDefault(x => x.ParameterType.Equals(type));
            if (param != null)
            {
                _configuredParameters.Add(new ConfiguredParameter(param, optional));
            }
            else
            {
                _instanceParameter = new InstanceParameter(type, predicate, optional);
            }

            return new InjectableMethodBuilder(this);
        }

        public InjectableMethodBuilder ConfigureInstanceParameter(Func<object, Func<ParameterInfo, bool>> predicate, bool optional = false)
        {
            _instanceParameter = new InstanceParameter(null, predicate, optional);
            return new InjectableMethodBuilder(this);
        }

        public InjectableMethodBuilder ConfigureInstanceParameter(Type type, bool optional = false)
        {
            ConfigureParameter(type, optional);
            return new InjectableMethodBuilder(this);
        }

        public InjectableMethodBuilder ReturnType(params Type[] returnTypes)
        {
            foreach (var item in returnTypes)
                _returnTypes.Add(item);

            return new InjectableMethodBuilder(this);
        }

        public ConfiguredMethodBuilder OnlyConfiguredParameters()
        {
            return new ConfiguredMethodBuilder(this);
        }

        internal void ValidateReturnType()
        {
            if (!_returnTypes.Any(z => z == _methodInfo.ReturnType))
            {
                throw new InvalidOperationException("Method must return at least one of the declared return types.");
            }
        }

        internal void ValidateInjectedParameters(int paramCount)
        {
            //if (_parameterInfos.Count() != paramCount)
            //{
            //    throw new InvalidOperationException("The create method must have the exact same number of injected parameters as the ones declared.");
            //}
        }
    }
}
