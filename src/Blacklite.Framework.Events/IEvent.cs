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
        IDictionary<string, string> Data { get; }
    }
}
