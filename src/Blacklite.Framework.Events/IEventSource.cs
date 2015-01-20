using System;

namespace Blacklite.Framework.Events
{
    public interface IEventSource<T>
        where T : IEvent
    {
        IObservable<T> Events { get; }
    }
}
