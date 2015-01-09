using System;
using System.Collections.Generic;
using System.Reflection;

namespace Blacklite.Framework.Shared.Reflection.Extensions.InjectorExtension
{
    public partial class InjectableMethodBuilder
    {
        public Func<IServiceProvider, TReturn> CreateFunc<TReturn>(object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(1);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();

            return new InjectableMethod(_methodInfo, _instanceParameter, _parameterInfos, _injectedParameterInfos, resolvedConfiguredParameter)
                .CreateFunc<TReturn>(container);
        }

        public Func<IServiceProvider, T1, TReturn> CreateFunc<T1, TReturn>(object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(1);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _injectedParameterInfos);

            return new InjectableMethod(_methodInfo, _instanceParameter, _parameterInfos, _injectedParameterInfos, resolvedConfiguredParameter)
                .CreateFunc<T1, TReturn>(container);
        }

        public Func<IServiceProvider, T1, T2, TReturn> CreateFunc<T1, T2, TReturn>(object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(2);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _injectedParameterInfos);

            return new InjectableMethod(_methodInfo, _instanceParameter, _parameterInfos, _injectedParameterInfos, resolvedConfiguredParameter)
                .CreateFunc<T1, T2, TReturn>(container);
        }

        public Func<IServiceProvider, T1, T2, T3, TReturn> CreateFunc<T1, T2, T3, TReturn>(object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(3);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _injectedParameterInfos);

            return new InjectableMethod(_methodInfo, _instanceParameter, _parameterInfos, _injectedParameterInfos, resolvedConfiguredParameter)
                .CreateFunc<T1, T2, T3, TReturn>(container);
        }

        public Func<IServiceProvider, T1, T2, T3, T4, TReturn> CreateFunc<T1, T2, T3, T4, TReturn>(object container)
        {
            ValidateReturnType();
            ValidateInjectedParameters(4);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _injectedParameterInfos);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _injectedParameterInfos);

            return new InjectableMethod(_methodInfo, _instanceParameter, _parameterInfos, _injectedParameterInfos, resolvedConfiguredParameter)
                .CreateFunc<T1, T2, T3, T4, TReturn>(container);
        }

        public Func<IServiceProvider, T1, T2, T3, T4, T5, TReturn> CreateFunc<T1, T2, T3, T4, T5, TReturn>(object container)
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
                .CreateFunc<T1, T2, T3, T4, T5, TReturn>(container);
        }

        public Func<IServiceProvider, T1, T2, T3, T4, T5, T6, TReturn> CreateFunc<T1, T2, T3, T4, T5, T6, TReturn>(object container)
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
                .CreateFunc<T1, T2, T3, T4, T5, T6, TReturn>(container);
        }

        public Func<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, TReturn> CreateFunc<T1, T2, T3, T4, T5, T6, T7, TReturn>(object container)
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
                .CreateFunc<T1, T2, T3, T4, T5, T6, T7, TReturn>(container);
        }

        public Func<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, TReturn> CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, TReturn>(object container)
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
                .CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, TReturn>(container);
        }

        public Func<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9, TReturn> CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TReturn>(object container)
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
                .CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TReturn>(container);
        }

        public Func<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn> CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn>(object container)
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
                .CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn>(container);
        }

        public Func<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TReturn> CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TReturn>(object container)
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
                .CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TReturn>(container);
        }

        public Func<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn> CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn>(object container)
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
                .CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn>(container);
        }

        public Func<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TReturn> CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TReturn>(object container)
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
                .CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TReturn>(container);
        }

        public Func<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TReturn> CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TReturn>(object container)
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
                .CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TReturn>(container);
        }

        public Func<IServiceProvider, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TReturn> CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TReturn>(object container)
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
                .CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TReturn>(container);
        }
    }
}
