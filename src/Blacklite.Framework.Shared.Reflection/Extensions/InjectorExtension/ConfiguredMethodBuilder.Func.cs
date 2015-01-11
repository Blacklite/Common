using System;
using System.Collections.Generic;
using System.Reflection;

namespace Blacklite.Framework.Shared.Reflection.Extensions.InjectorExtension
{
    public partial class ConfiguredMethodBuilder
    {
        public Func<TReturn> CreateFunc<TReturn>(object container)
        {
            ValidateParameters();

            _builder.ValidateReturnType();


            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();

            return new ConfiguredMethod(_builder._methodInfo, _builder._instanceParameter, _builder._configuredParameters, resolvedConfiguredParameter)
                .CreateFunc<TReturn>(container);
        }

        public Func<T1, TReturn> CreateFunc<T1, TReturn>(object container)
        {
            ValidateParameters();

            _builder.ValidateReturnType();
            _builder.ValidateInjectedParameters(1);


            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _builder._configuredParameters);

            return new ConfiguredMethod(_builder._methodInfo, _builder._instanceParameter, _builder._configuredParameters, resolvedConfiguredParameter)
                .CreateFunc<T1, TReturn>(container);
        }

        public Func<T1, T2, TReturn> CreateFunc<T1, T2, TReturn>(object container)
        {
            ValidateParameters();

            _builder.ValidateReturnType();
            _builder.ValidateInjectedParameters(2);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _builder._configuredParameters);

            return new ConfiguredMethod(_builder._methodInfo, _builder._instanceParameter, _builder._configuredParameters, resolvedConfiguredParameter)
                .CreateFunc<T1, T2, TReturn>(container);
        }

        public Func<T1, T2, T3, TReturn> CreateFunc<T1, T2, T3, TReturn>(object container)
        {
            ValidateParameters();

            _builder.ValidateReturnType();
            _builder.ValidateInjectedParameters(3);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _builder._configuredParameters);

            return new ConfiguredMethod(_builder._methodInfo, _builder._instanceParameter, _builder._configuredParameters, resolvedConfiguredParameter)
                .CreateFunc<T1, T2, T3, TReturn>(container);
        }

        public Func<T1, T2, T3, T4, TReturn> CreateFunc<T1, T2, T3, T4, TReturn>(object container)
        {
            ValidateParameters();

            _builder.ValidateReturnType();
            _builder.ValidateInjectedParameters(4);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _builder._configuredParameters);

            return new ConfiguredMethod(_builder._methodInfo, _builder._instanceParameter, _builder._configuredParameters, resolvedConfiguredParameter)
                .CreateFunc<T1, T2, T3, T4, TReturn>(container);
        }

        public Func<T1, T2, T3, T4, T5, TReturn> CreateFunc<T1, T2, T3, T4, T5, TReturn>(object container)
        {
            ValidateParameters();

            _builder.ValidateReturnType();
            _builder.ValidateInjectedParameters(5);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T5), _builder._configuredParameters);

            return new ConfiguredMethod(_builder._methodInfo, _builder._instanceParameter, _builder._configuredParameters, resolvedConfiguredParameter)
                .CreateFunc<T1, T2, T3, T4, T5, TReturn>(container);
        }

        public Func<T1, T2, T3, T4, T5, T6, TReturn> CreateFunc<T1, T2, T3, T4, T5, T6, TReturn>(object container)
        {
            ValidateParameters();

            _builder.ValidateReturnType();
            _builder.ValidateInjectedParameters(6);

            var resolvedConfiguredParameter = new Dictionary<TypeInfo, ConfiguredParameter>();
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T1), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T2), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T3), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T4), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T5), _builder._configuredParameters);
            resolvedConfiguredParameter.GetConfigureParameter(typeof(T6), _builder._configuredParameters);

            return new ConfiguredMethod(_builder._methodInfo, _builder._instanceParameter, _builder._configuredParameters, resolvedConfiguredParameter)
                .CreateFunc<T1, T2, T3, T4, T5, T6, TReturn>(container);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, TReturn> CreateFunc<T1, T2, T3, T4, T5, T6, T7, TReturn>(object container)
        {
            ValidateParameters();

            _builder.ValidateReturnType();
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
                .CreateFunc<T1, T2, T3, T4, T5, T6, T7, TReturn>(container);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, TReturn> CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, TReturn>(object container)
        {
            ValidateParameters();

            _builder.ValidateReturnType();
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
                .CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, TReturn>(container);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TReturn> CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TReturn>(object container)
        {
            ValidateParameters();

            _builder.ValidateReturnType();
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
                .CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TReturn>(container);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn> CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn>(object container)
        {
            ValidateParameters();

            _builder.ValidateReturnType();
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
                .CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn>(container);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TReturn> CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TReturn>(object container)
        {
            ValidateParameters();

            _builder.ValidateReturnType();
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
                .CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TReturn>(container);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn> CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn>(object container)
        {
            ValidateParameters();

            _builder.ValidateReturnType();
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
                .CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn>(container);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TReturn> CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TReturn>(object container)
        {
            ValidateParameters();

            _builder.ValidateReturnType();
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
                .CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TReturn>(container);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TReturn> CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TReturn>(object container)
        {
            ValidateParameters();

            _builder.ValidateReturnType();
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
                .CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TReturn>(container);
        }

        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TReturn> CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TReturn>(object container)
        {
            ValidateParameters();

            _builder.ValidateReturnType();
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
                .CreateFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TReturn>(container);
        }
    }
}
