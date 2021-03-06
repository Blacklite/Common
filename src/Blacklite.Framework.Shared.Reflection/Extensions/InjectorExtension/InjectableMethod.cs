﻿using Microsoft.Framework.DependencyInjection;
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
        private readonly TypeInfo _methodReturnTypeInfo;
        private int _numParams;
        private readonly IDictionary<TypeInfo, ConfiguredParameter> _resolvedConfiguredParameter;

        internal InjectableMethod(
            [NotNull] MethodInfo methodInfo,
            [NotNull] InstanceParameter instanceParameter,
            [NotNull] IEnumerable<ConfiguredParameter> configuredParameters,
            [NotNull] IDictionary<TypeInfo, ConfiguredParameter> resolvedConfiguredParameter)
        {
            _voidReturnType = methodInfo.ReturnType == typeof(void);
            _methodInfo = methodInfo;
            _instanceParameter = instanceParameter;
            _configuredParameters = configuredParameters;
            _numParams = methodInfo.GetParameters().Count();
            _resolvedConfiguredParameter = resolvedConfiguredParameter;
            _methodReturnTypeInfo = _methodInfo.ReturnType.GetTypeInfo();

            if (_instanceParameter != null && _instanceParameter.ParameterInfo != null)
            {
                _configuredParameters = configuredParameters.Union(new[] { _instanceParameter });
                _instanceParameter = null;
            }
            if (_instanceParameter != null && _instanceParameter.Predicate == null)
                throw new Exception("Instance param requires a predicate if it is not well defined.");

            _injectableParameters = methodInfo.GetParameters().Except(_configuredParameters.Select(x => x.ParameterInfo)).ToArray();
        }

        private void UpdateInstanceParameter<T>(T instance)
        {
            if (_instanceParameter != null && instance != null)
            {
                if (_instanceParameter.Predicate != null)
                {
                    var type = instance?.GetType() ?? typeof(T);
                    var typeInfo = type.GetTypeInfo();

                    var param = _injectableParameters.SingleOrDefault(_instanceParameter.Predicate(type));

                    if (param != null)
                    {
                        _configuredParameters = _configuredParameters.Union(new[] { new InstanceParameter(param, param.IsOptional) });
                        _injectableParameters = _injectableParameters.Except(_configuredParameters.Select(x => x.ParameterInfo));

                        if (_resolvedConfiguredParameter.ContainsKey(typeInfo))
                            _resolvedConfiguredParameter.Remove(typeInfo);
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

        protected virtual void InjectParameters(IServiceProvider serviceProvider, object[] parameters)
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
                        throw new InvalidOperationException(string.Format(
                            "Unable to resolve required service for {0} method {1} {2}",
                            _methodInfo.Name,
                            parameterInfo.Name,
                            parameterInfo.ParameterType.FullName));
                    }
                }
            }
        }

        private void SetConfiguredParameter<T>(object[] parameters, T value)
        {
            UpdateInstanceParameter(value);
            var configuredParam = _resolvedConfiguredParameter.GetConfigureParameter(value?.GetType() ?? typeof(T), _configuredParameters);
            if (configuredParam != null)
            {
                parameters[configuredParam.ParameterInfo.Position] = value;
            }
        }

        private static MethodInfo _emptyMethod = typeof(Enumerable).GetTypeInfo().DeclaredMethods.Single(x => x.Name == nameof(Enumerable.Empty));
        private TReturn GetDefaultReturnValue<TReturn>(TypeInfo typeInfo)
        {

            // type is IEnumerable<T>;
            if (typeInfo.IsGenericType && typeInfo.GetGenericTypeDefinition() == typeof(IEnumerable<>))
            {
                var enumType = typeInfo.GenericTypeArguments[0];
                return (TReturn)_emptyMethod.MakeGenericMethod(enumType).Invoke(null, new object[] { });
            }

            return default(TReturn);
        }

        private TReturn GetResult<TReturn>(object container, object[] parameters, TReturn returnDefault, TypeInfo returnTypeInfo)
        {
            if (!_voidReturnType && returnTypeInfo.IsInterface && _methodReturnTypeInfo.ImplementedInterfaces.Contains(returnTypeInfo.AsType()) || _methodReturnTypeInfo.IsAssignableFrom(returnTypeInfo))
            {
                return (TReturn)_methodInfo.Invoke(container, parameters);
            }

            _methodInfo.Invoke(container, parameters);
            return returnDefault;
        }

        private void ExecuteResult(object container, object[] parameters)
        {
            _methodInfo.Invoke(container, parameters);
        }
    }
}
