using System;

namespace Blacklite.Framework.Steps
{
    public interface IStepContextProvider
    {
        IStepContext GetContextFor<T>(T instance);
    }

    public interface IStepContext
    {
        IServiceProvider ProcessServices { get; }
    }
}
