using Blacklite.Framework.Events;
using System;

namespace Blacklite.Framework.GlobalEvents
{
    public interface IGlobalEventSource : IObservable<IEvent> { }
}
