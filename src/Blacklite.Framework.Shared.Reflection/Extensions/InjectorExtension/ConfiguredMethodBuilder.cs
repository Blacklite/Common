using System;
using System.Linq;

namespace Blacklite.Framework.Shared.Reflection.Extensions.InjectorExtension
{
    public partial class ConfiguredMethodBuilder
    {
        private readonly InjectableMethodBuilder _builder;
        internal ConfiguredMethodBuilder(InjectableMethodBuilder builder)
        {
            _builder = builder;
        }

        private void ValidateParameters()
        {
            if (_builder._methodInfo.GetParameters().Count() < _builder._configuredParameters.Count())
            {
                throw new InvalidOperationException("Method cannot have extra parameters that are not found in the list of configured parameters.");
            }
        }
    }
}
