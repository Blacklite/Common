using System;
using System.Collections.Generic;
using System.Reflection;

namespace Blacklite.Framework.Shared.Reflection.Extensions.InjectorExtension
{
    public partial class InjectableMethodBuilder
    {
        public Action<IServiceProvider> CreateAction(object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(0);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();

            return new InjectableMethod(_methodInfo, _instanceParameter, _parameterInfos, _injectedParameterInfos, resolvedConfiguredParameter)
                .CreateAction(container);
        }

        public Action<IServiceProvider, T1> CreateAction<T1>(object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(1);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _injectedParameterInfos);

            return new InjectableMethod(_methodInfo, _instanceParameter, _parameterInfos, _injectedParameterInfos, resolvedConfiguredParameter)
                .CreateAction<T1>(container);
        }

        public Action<IServiceProvider, T1, T2> CreateAction<T1, T2>(object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(2);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _injectedParameterInfos);

            return new InjectableMethod(_methodInfo, _instanceParameter, _parameterInfos, _injectedParameterInfos, resolvedConfiguredParameter)
                .CreateAction<T1, T2>(container);
        }

        public Action<IServiceProvider, T1, T2, T3> CreateAction<T1, T2, T3>(object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(3);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _injectedParameterInfos);

            return new InjectableMethod(_methodInfo, _instanceParameter, _parameterInfos, _injectedParameterInfos, resolvedConfiguredParameter)
                .CreateAction<T1, T2, T3>(container);
        }

        public Action<IServiceProvider, T1, T2, T3, T4> CreateAction<T1, T2, T3, T4>(object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(4);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _injectedParameterInfos);

            return new InjectableMethod(_methodInfo, _instanceParameter, _parameterInfos, _injectedParameterInfos, resolvedConfiguredParameter)
                .CreateAction<T1, T2, T3, T4>(container);
        }

        public Action<IServiceProvider, T1, T2, T3, T4, T5> CreateAction<T1, T2, T3, T4, T5>(object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(5);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T5), _injectedParameterInfos);

            return new InjectableMethod(_methodInfo, _instanceParameter, _parameterInfos, _injectedParameterInfos, resolvedConfiguredParameter)
                .CreateAction<T1, T2, T3, T4, T5>(container);
        }

        public Action<IServiceProvider, T1, T2, T3, T4, T5, T6> CreateAction<T1, T2, T3, T4, T5, T6>(object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(6);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T5), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T6), _injectedParameterInfos);

            return new InjectableMethod(_methodInfo, _instanceParameter, _parameterInfos, _injectedParameterInfos, resolvedConfiguredParameter)
                .CreateAction<T1, T2, T3, T4, T5, T6>(container);
        }

        public Action<IServiceProvider, T1, T2, T3, T4, T5, T6, T7> CreateAction<T1, T2, T3, T4, T5, T6, T7>(object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(7);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T5), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T6), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T7), _injectedParameterInfos);

            return new InjectableMethod(_methodInfo, _instanceParameter, _parameterInfos, _injectedParameterInfos, resolvedConfiguredParameter)
                .CreateAction<T1, T2, T3, T4, T5, T6, T7>(container);
        }

        public Action<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8> CreateAction<T1, T2, T3, T4, T5, T6, T7, T8>(object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(8);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T5), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T6), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T7), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T8), _injectedParameterInfos);

            return new InjectableMethod(_methodInfo, _instanceParameter, _parameterInfos, _injectedParameterInfos, resolvedConfiguredParameter)
                .CreateAction<T1, T2, T3, T4, T5, T6, T7, T8>(container);
        }

        public Action<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9> CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>(object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(9);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T5), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T6), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T7), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T8), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T9), _injectedParameterInfos);

            return new InjectableMethod(_methodInfo, _instanceParameter, _parameterInfos, _injectedParameterInfos, resolvedConfiguredParameter)
                .CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>(container);
        }

        public Action<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(10);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T5), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T6), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T7), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T8), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T9), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T10), _injectedParameterInfos);

            return new InjectableMethod(_methodInfo, _instanceParameter, _parameterInfos, _injectedParameterInfos, resolvedConfiguredParameter)
                .CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(container);
        }

        public Action<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(11);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T5), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T6), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T7), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T8), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T9), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T10), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T11), _injectedParameterInfos);

            return new InjectableMethod(_methodInfo, _instanceParameter, _parameterInfos, _injectedParameterInfos, resolvedConfiguredParameter)
                .CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(container);
        }

        public Action<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(12);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T5), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T6), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T7), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T8), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T9), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T10), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T11), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T12), _injectedParameterInfos);

            return new InjectableMethod(_methodInfo, _instanceParameter, _parameterInfos, _injectedParameterInfos, resolvedConfiguredParameter)
                .CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(container);
        }

        public Action<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(13);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T5), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T6), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T7), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T8), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T9), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T10), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T11), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T12), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T13), _injectedParameterInfos);

            return new InjectableMethod(_methodInfo, _instanceParameter, _parameterInfos, _injectedParameterInfos, resolvedConfiguredParameter)
                .CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(container);
        }

        public Action<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(14);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T5), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T6), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T7), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T8), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T9), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T10), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T11), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T12), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T13), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T14), _injectedParameterInfos);

            return new InjectableMethod(_methodInfo, _instanceParameter, _parameterInfos, _injectedParameterInfos, resolvedConfiguredParameter)
                .CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(container);
        }

        public Action<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(15);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T5), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T6), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T7), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T8), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T9), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T10), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T11), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T12), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T13), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T14), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T15), _injectedParameterInfos);

            return new InjectableMethod(_methodInfo, _instanceParameter, _parameterInfos, _injectedParameterInfos, resolvedConfiguredParameter)
                .CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(container);
        }
    }
}
