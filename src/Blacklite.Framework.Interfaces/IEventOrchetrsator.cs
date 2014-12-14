using System;

namespace Blacklite.Framework
{
    public interface IEventOrchestrator
    {
        void Broadcast(IEvent value);
        IObservable<IEvent> Events { get; }
    }
}
