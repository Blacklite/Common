using System;
using System.Collections.Generic;

namespace Blacklite.Framework.GlobalEvents
{
    public class GlobalEventOptions
    {
        public IList<IObservable<IGlobalEvent>> Sources { get; } = new List<IObservable<IGlobalEvent>>();
    }
}
