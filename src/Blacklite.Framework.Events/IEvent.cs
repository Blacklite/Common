using System;
using System.Collections.Generic;

namespace Blacklite.Framework.Events
{
    public interface IEvent
    {
        string Type { get; }
        string Name { get; }
        string User { get; }
        string Reason { get; }
        IReadOnlyDictionary<string, string> Data { get; }
    }
}
