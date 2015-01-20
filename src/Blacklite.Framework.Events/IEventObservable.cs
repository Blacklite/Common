using System;

namespace Blacklite.Framework.Events
{
    public interface IEventObservable<T> : IObservable<T> where T : IEvent { }
}
