using System;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Disposables;
using System.Reactive.Subjects;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace Blacklite.Framework.Events
{
    public class EventSource : IObservable<IEvent>
    {
        public static EventSource Global = new EventSource();

        public EventSource()
        {
            _observable = _subject
                .SelectMany(events => Observable.Merge(events))
                .Replay(1)
                .Publish()
                .RefCount();
        }

        private readonly IObservable<IEvent> _observable;
        private readonly object _lock = new object();
        private readonly HashSet<IObservable<IEvent>> _streams = new HashSet<IObservable<IEvent>>();
        private readonly Subject<IObservable<IEvent>[]> _subject = new Subject<IObservable<IEvent>[]>();

        public IDisposable Add(IObservable<IEvent> stream)
        {
            lock (_lock)
            {
                _streams.Add(stream);
            }

            _subject.OnNext(_streams.ToArray());
            return Disposable.Create(() =>
            {
                lock (_lock)
                {
                    _streams.Remove(stream);

                }
                _subject.OnNext(_streams.ToArray());
            });
        }

        public IDisposable Subscribe(IObserver<IEvent> observer)
        {
            return _observable.Subscribe(observer);
        }
    }
}
