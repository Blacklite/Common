using Microsoft.Framework.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Blacklite.Framework.Shared.Reflection.Extensions.InjectorExtension
{
    partial class InjectableMethod
    {
        private readonly bool _voidReturnType;
        private readonly MethodInfo _methodInfo;
        private InstanceParameter _instanceParameter;
        private IEnumerable<ParameterInfo> _injectableParameters;
        private IEnumerable<ConfiguredParameter> _configuredParameters;
        private int _numParams;
        private readonly IDictionary<TypeInfo, ConfiguredParameter> _resolvedConfiguredParameter;

        internal InjectableMethod(
            MethodInfo methodInfo,
            InstanceParameter instanceParameter,
            IEnumerable<ParameterInfo> injectableParameters,
            IEnumerable<ConfiguredParameter> configuredParameters,
            IDictionary<TypeInfo, ConfiguredParameter> resolvedConfiguredParameter)
        {
            _voidReturnType = methodInfo.ReturnType == typeof(void);
            _methodInfo = methodInfo;
            _instanceParameter = instanceParameter;
            _configuredParameters = configuredParameters;
            _numParams = methodInfo.GetParameters().Count();
            _resolvedConfiguredParameter = resolvedConfiguredParameter;

            if (_instanceParameter != null && _instanceParameter.ParameterInfo != null)
            {
                _instanceParameter = null;
                _configuredParameters = _configuredParameters.Union(new[] { _instanceParameter });
            }

            _injectableParameters = injectableParameters.Except(_configuredParameters.Select(x => x.ParameterInfo));
        }

        private void UpdateInstanceParameter(object instance)
        {
            if (_instanceParameter != null && instance != null)
            {
                if (_instanceParameter.Predicate != null)
                {
                    var param = _injectableParameters.SingleOrDefault(_instanceParameter.Predicate(instance));

                    if (param != null)
                    {
                        _configuredParameters = _configuredParameters.Union(new[] { new InstanceParameter(param, param.IsOptional) });
                        _injectableParameters = _injectableParameters.Except(_configuredParameters.Select(x => x.ParameterInfo));
                    }

                    if (param == null)
                    {
                        if (!_instanceParameter.Optional)
                            throw new InvalidOperationException(string.Format("Missing required parameter type '{0}'", _instanceParameter.TypeInfo.FullName));
                    }
                }

                _instanceParameter = null;
            }
        }

        private void InjectParameters(IServiceProvider serviceProvider, object[] parameters)
        {
            foreach (var parameterInfo in _injectableParameters)
            {
                if (parameterInfo.IsOptional)
                {
                    parameters[parameterInfo.Position] = serviceProvider.GetService(parameterInfo.ParameterType);
                }
                else
                {
                    try
                    {
                        parameters[parameterInfo.Position] = serviceProvider.GetRequiredService(parameterInfo.ParameterType);
                    }
                    catch (Exception)
                    {
                        throw new Exception(string.Format(
                            "TODO: Unable to resolve required service for {0} method {1} {2}",
                            _methodInfo.Name,
                            parameterInfo.Name,
                            parameterInfo.ParameterType.FullName));
                    }
                }
            }
        }

        private void SetConfiguredParameter<T>(object[] parameters, T value)
        {
            var configuredParam = _resolvedConfiguredParameter.GetConfigureParameter(typeof(T), _configuredParameters);
            if (configuredParam != null)
            {
                //if (!configuredParam.Optional)
                //{
                //    var isDefault = value?.Equals(default(T));
                //    if (isDefault.HasValue && isDefault.Value || !isDefault.HasValue)
                //        throw new MissingMemberException(string.Format("No value given for required param '{0}'", configuredParam.ParameterInfo.Name));
                //}
                parameters[configuredParam.ParameterInfo.Position] = value;
            }
        }

        private static MethodInfo _emptyMethod = typeof(Enumerable).GetTypeInfo().DeclaredMethods.Single(x => x.Name == nameof(Enumerable.Empty));
        private TReturn GetDefaultReturnValue<TReturn>(TypeInfo typeInfo)
        {
            Type enumType = null;

            // type is IEnumerable<T>;
            if (typeInfo.IsGenericType && typeInfo.GetGenericTypeDefinition() == typeof(IEnumerable<>))
                enumType = typeInfo.GenericTypeArguments[0];

            if (enumType == null)
                // type implements/extends IEnumerable<T>;
                enumType = typeInfo.ImplementedInterfaces
                    .Where(t => t.GetTypeInfo().IsGenericType && t.GetGenericTypeDefinition() == typeof(IEnumerable<>))
                    .Select(t => t.GenericTypeArguments[0])
                    .FirstOrDefault();

            if (enumType != null)
            {
                return (TReturn)_emptyMethod.MakeGenericMethod(enumType).Invoke(null, null);
            }
            return default(TReturn);
        }

        private TReturn GetResult<TReturn>(object container, object[] parameters, TReturn returnDefault)
        {
            if (_voidReturnType)
            {
                _methodInfo.Invoke(container, parameters);
                return returnDefault;
            }

            return (TReturn)_methodInfo.Invoke(container, parameters);
        }

        private void ExecuteResult(object container, object[] parameters)
        {
            _methodInfo.Invoke(container, parameters);
        }
    }

}
