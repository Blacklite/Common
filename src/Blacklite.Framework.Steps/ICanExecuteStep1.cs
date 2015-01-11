using System;

namespace Blacklite.Framework.Steps
{
    public interface ICanExecuteStep
    {
        bool CanExecute([NotNull] object instance, [NotNull] IStepContext context);
    }
}
