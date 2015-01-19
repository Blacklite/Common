using System;

namespace Blacklite.Framework.GlobalEvents
{
    class GlobalObservable : IEventObservable<IGlobalEvent>
    {
        private readonly IObservable<IGlobalEvent> _observable;
        public GlobalObservable([NotNull] IEventOrchestrator<IGlobalEvent> orchestrator)
        {
            _observable = orchestrator.Events;
        }

        public IDisposable Subscribe(IObserver<IGlobalEvent> observer)
        {
            return _observable.Subscribe(observer);
        }
    }
}
