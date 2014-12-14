using System;

namespace Blacklite.Framework.GlobalEvents
{


    public class GlobalObservable : IEventObservable
    {
        private readonly IObservable<IEvent> _observable;
        public GlobalObservable([NotNull] IEventOrchestrator orchestrator)
        {
            _observable = orchestrator.Events;
        }

        public IDisposable Subscribe(IObserver<IEvent> observer)
        {
            return _observable.Subscribe(observer);
        }
    }
}
