using System;

namespace Blacklite.Framework.Events
{
    public interface IEventOrchestrator<T> where T : IEvent
    {
        void Broadcast([NotNull] T value);
        IObservable<T> Events { get; }
    }
}
