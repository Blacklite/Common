using System;
using System.Collections.Generic;
using System.Reflection;

namespace Blacklite.Framework.Shared.Reflection.Extensions.InjectorExtension
{
    public partial class ConfiguredMethodBuilder
    {
        public Action CreateAction(object container)
        {
            ValidateParameters();


            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();

            return new ConfiguredMethod(_builder._methodInfo, _builder._instanceParameter, _builder._configuredParameters, resolvedConfiguredParameter)
                .CreateAction(container);
        }

        public Action<T1> CreateAction<T1>(object container)
        {
            ValidateParameters();



            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _builder._configuredParameters);

            return new ConfiguredMethod(_builder._methodInfo, _builder._instanceParameter, _builder._configuredParameters, resolvedConfiguredParameter)
                .CreateAction<T1>(container);
        }

        public Action<T1, T2> CreateAction<T1, T2>(object container)
        {
            ValidateParameters();

            _builder.ValidateInjectedParameters(2);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _builder._configuredParameters);

            return new ConfiguredMethod(_builder._methodInfo, _builder._instanceParameter, _builder._configuredParameters, resolvedConfiguredParameter)
                .CreateAction<T1, T2>(container);
        }

        public Action<T1, T2, T3> CreateAction<T1, T2, T3>(object container)
        {
            ValidateParameters();

            _builder.ValidateInjectedParameters(3);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _builder._configuredParameters);

            return new ConfiguredMethod(_builder._methodInfo, _builder._instanceParameter, _builder._configuredParameters, resolvedConfiguredParameter)
                .CreateAction<T1, T2, T3>(container);
        }

        public Action<T1, T2, T3, T4> CreateAction<T1, T2, T3, T4>(object container)
        {
            ValidateParameters();

            _builder.ValidateInjectedParameters(4);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _builder._configuredParameters);

            return new ConfiguredMethod(_builder._methodInfo, _builder._instanceParameter, _builder._configuredParameters, resolvedConfiguredParameter)
                .CreateAction<T1, T2, T3, T4>(container);
        }

        public Action<T1, T2, T3, T4, T5> CreateAction<T1, T2, T3, T4, T5>(object container)
        {
            ValidateParameters();

            _builder.ValidateInjectedParameters(5);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T5), _builder._configuredParameters);

            return new ConfiguredMethod(_builder._methodInfo, _builder._instanceParameter, _builder._configuredParameters, resolvedConfiguredParameter)
                .CreateAction<T1, T2, T3, T4, T5>(container);
        }

        public Action<T1, T2, T3, T4, T5, T6> CreateAction<T1, T2, T3, T4, T5, T6>(object container)
        {
            ValidateParameters();

            _builder.ValidateInjectedParameters(6);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T5), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T6), _builder._configuredParameters);

            return new ConfiguredMethod(_builder._methodInfo, _builder._instanceParameter, _builder._configuredParameters, resolvedConfiguredParameter)
                .CreateAction<T1, T2, T3, T4, T5, T6>(container);
        }

        public Action<T1, T2, T3, T4, T5, T6, T7> CreateAction<T1, T2, T3, T4, T5, T6, T7>(object container)
        {
            ValidateParameters();

            _builder.ValidateInjectedParameters(7);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T5), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T6), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T7), _builder._configuredParameters);

            return new ConfiguredMethod(_builder._methodInfo, _builder._instanceParameter, _builder._configuredParameters, resolvedConfiguredParameter)
                .CreateAction<T1, T2, T3, T4, T5, T6, T7>(container);
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8> CreateAction<T1, T2, T3, T4, T5, T6, T7, T8>(object container)
        {
            ValidateParameters();

            _builder.ValidateInjectedParameters(8);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T5), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T6), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T7), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T8), _builder._configuredParameters);

            return new ConfiguredMethod(_builder._methodInfo, _builder._instanceParameter, _builder._configuredParameters, resolvedConfiguredParameter)
                .CreateAction<T1, T2, T3, T4, T5, T6, T7, T8>(container);
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>(object container)
        {
            ValidateParameters();

            _builder.ValidateInjectedParameters(9);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T5), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T6), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T7), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T8), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T9), _builder._configuredParameters);

            return new ConfiguredMethod(_builder._methodInfo, _builder._instanceParameter, _builder._configuredParameters, resolvedConfiguredParameter)
                .CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>(container);
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(object container)
        {
            ValidateParameters();

            _builder.ValidateInjectedParameters(10);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T5), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T6), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T7), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T8), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T9), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T10), _builder._configuredParameters);

            return new ConfiguredMethod(_builder._methodInfo, _builder._instanceParameter, _builder._configuredParameters, resolvedConfiguredParameter)
                .CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(container);
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(object container)
        {
            ValidateParameters();

            _builder.ValidateInjectedParameters(11);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T5), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T6), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T7), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T8), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T9), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T10), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T11), _builder._configuredParameters);

            return new ConfiguredMethod(_builder._methodInfo, _builder._instanceParameter, _builder._configuredParameters, resolvedConfiguredParameter)
                .CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(container);
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(object container)
        {
            ValidateParameters();

            _builder.ValidateInjectedParameters(12);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T5), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T6), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T7), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T8), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T9), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T10), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T11), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T12), _builder._configuredParameters);

            return new ConfiguredMethod(_builder._methodInfo, _builder._instanceParameter, _builder._configuredParameters, resolvedConfiguredParameter)
                .CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(container);
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(object container)
        {
            ValidateParameters();

            _builder.ValidateInjectedParameters(13);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T5), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T6), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T7), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T8), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T9), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T10), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T11), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T12), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T13), _builder._configuredParameters);

            return new ConfiguredMethod(_builder._methodInfo, _builder._instanceParameter, _builder._configuredParameters, resolvedConfiguredParameter)
                .CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(container);
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(object container)
        {
            ValidateParameters();

            _builder.ValidateInjectedParameters(14);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T5), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T6), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T7), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T8), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T9), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T10), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T11), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T12), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T13), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T14), _builder._configuredParameters);

            return new ConfiguredMethod(_builder._methodInfo, _builder._instanceParameter, _builder._configuredParameters, resolvedConfiguredParameter)
                .CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(container);
        }

        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(object container)
        {
            ValidateParameters();

            _builder.ValidateInjectedParameters(15);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T5), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T6), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T7), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T8), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T9), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T10), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T11), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T12), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T13), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T14), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T15), _builder._configuredParameters);

            return new ConfiguredMethod(_builder._methodInfo, _builder._instanceParameter, _builder._configuredParameters, resolvedConfiguredParameter)
                .CreateAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(container);
        }
    }
}
