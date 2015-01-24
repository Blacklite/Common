using System;

namespace Blacklite.Framework.Events
{
    public interface IEventSource<T> : IObservable<T>
        where T : IEvent
    {
    }
}
