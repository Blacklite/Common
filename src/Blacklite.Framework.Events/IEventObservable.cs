using System;

namespace Blacklite.Framework.Events
{
    public interface IEventObservable<out T> : IObservable<T> where T : IEvent { }
}
