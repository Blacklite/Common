using System;
using System.Reactive;
using System.Reactive.Subjects;

namespace Blacklite.Framework.GlobalEvents
{
    public class GlobalOrchestrator : IEventOrchestrator
    {
        private readonly ISubject<IEvent> _subject;

        public GlobalOrchestrator()
        {
            _subject = new Subject<IEvent>();
            Events = _subject;
        }

        public IObservable<IEvent> Events { get; }

        public void Broadcast(IEvent value)
        {
            _subject.OnNext(value);
        }
    }
}
