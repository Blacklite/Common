using System;
using Blacklite.Framework.Events;
using System.Reactive;
using System.Reactive.Linq;
using System.Collections.Generic;
using System.Linq;

namespace Blacklite.Framework.GlobalEvents
{
    class GlobalObservable : IEventObservable<IGlobalEvent>
    {
        private readonly IObservable<IGlobalEvent> _observable;
        public GlobalObservable([NotNull] IEnumerable<IGlobalEventSource> sources)
        {
            _observable = sources.Merge().Select(GlobalEvent.Create);
        }

        public IDisposable Subscribe(IObserver<IGlobalEvent> observer)
        {
            return _observable.Subscribe(observer);
        }
    }
}
