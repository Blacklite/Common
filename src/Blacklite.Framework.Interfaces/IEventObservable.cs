using System;

namespace Blacklite.Framework
{
    [AssemblyNeutral]
    public interface IEventObservable : IObservable<IEvent> { }
}
