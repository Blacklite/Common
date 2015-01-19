using System;

namespace Blacklite.Framework
{
    public interface IEventObservable<T> : IObservable<T> where T : IEvent { }
}
