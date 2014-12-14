using System;

namespace Blacklite.Framework
{
    [AssemblyNeutral]
    public interface IEventOrchestrator
    {
        void Broadcast([NotNull] IEvent value);
        IObservable<IEvent> Events { get; }
    }
}
