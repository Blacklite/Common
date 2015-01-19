using System;
using System.Reactive;
using System.Reactive.Subjects;

namespace Blacklite.Framework.GlobalEvents
{
    class GlobalOrchestrator : IEventOrchestrator<IGlobalEvent>
    {
        private readonly ISubject<IGlobalEvent> _subject;

        public GlobalOrchestrator()
        {
            _subject = new Subject<IGlobalEvent>();
            Events = _subject;
        }

        public IObservable<IGlobalEvent> Events { get; }

        public void Broadcast(IGlobalEvent value)
        {
            _subject.OnNext(value);
        }
    }
}
