using System;
using System.Collections.Generic;

namespace Blacklite.Framework.Events
{
    public interface IEvent
    {
        string Category { get; }
        string Type { get; }
        IReadOnlyDictionary<string, object> Data { get; }
    }
}
