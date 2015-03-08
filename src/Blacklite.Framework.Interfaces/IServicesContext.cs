using System;

namespace Blacklite.Framework
{
    public interface IServicesContext
    {
        IServiceProvider ServiceProvider { get; }
    }
}
