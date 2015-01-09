using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Blacklite.Framework.Shared.Reflection.Extensions.InjectorExtension
{
    public partial class InjectableMethodBuilder
    {
        private readonly MethodInfo _methodInfo;
        private readonly IEnumerable<ParameterInfo> _parameterInfos;
        private InstanceParameter _instanceParameter;
        private readonly IList<ConfiguredParameter> _injectedParameterInfos = new List<ConfiguredParameter>();
        private readonly IList<Type> _returnTypes;

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
            _injectedParameterInfos = builder._injectedParameterInfos.ToList();
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
                _injectedParameterInfos.Add(new ConfiguredParameter(param, optional));

            return new InjectableMethodBuilder(this);
        }

        public InjectableMethodBuilder ConfigureParameter(Type type, bool optional = false)
        {
            // lack of optional means its required.
            var param = _parameterInfos.SingleOrDefault(x => x.ParameterType.Equals(type));
            if (param == null && !optional)
            {
                throw new MissingMemberException(string.Format("Could not find injectable property for predicate '{0}'", type.FullName));
            }

            if (param != null)
                _injectedParameterInfos.Add(new ConfiguredParameter(param, optional));

            return new InjectableMethodBuilder(this);
        }

        public InjectableMethodBuilder ConfigureInstanceParameter(Type type, Func<object, Func<ParameterInfo, bool>> predicate, bool optional = false)
        {
            // lack of optional means its required.
            var param = _parameterInfos.SingleOrDefault(x => x.ParameterType.Equals(type));
            if (param != null)
                _injectedParameterInfos.Add(new ConfiguredParameter(param, optional));
            else
                _instanceParameter = new InstanceParameter(type, predicate, optional);

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

        private void ValidateReturnType()
        {
            if (!_returnTypes.Any(z => z == _methodInfo.ReturnType))
            {
                throw new InvalidOperationException("Method must return at least one of the declared return types.");
            }
        }

        private void ValidateInjectedParameters(int paramCount)
        {
            if (_injectedParameterInfos.Count != paramCount)
            {
                throw new InvalidOperationException("The create method must have the exact same number of injected parameters as the ones declared.");
            }
        }
    }
}
