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
    public static class EventSource
    {
        public static EventSource<IEvent> Global = new EventSource<IEvent>();
    }

    public class EventSource<T> : IObservable<T>
        where T : IEvent
    {
        private readonly object _lock = new object();
        private readonly IObservable<T> _observable;
        private readonly HashSet<IObservable<T>> _streams;
        private readonly Subject<IObservable<T>[]> _subject;

        public EventSource()
        {
            _streams = new HashSet<IObservable<T>>();
            _subject = new Subject<IObservable<T>[]>();
            var observable = _subject
                .Replay(1)
                .RefCount()
                .Select(events =>
                {
                    return Observable.Merge(events);
                })
                .Switch()
                .Replay(1)
                //.Publish()
                .RefCount()
                ;

            //observable.Connect();
            _observable = observable;

            //_subject.Subscribe((a) => Console.WriteLine("_subject fired!"));
            //_observable.Subscribe((a) => Console.WriteLine("_observable fired!"));
        }

        public IDisposable Add(IObservable<T> stream)
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

        public IDisposable Subscribe(IObserver<T> observer)
        {
            return _observable.Subscribe(observer);
        }
    }
}
