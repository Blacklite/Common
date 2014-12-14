using System;

namespace Blacklite.Framework
{
    public interface IEvent
    {
        string Type { get; }
        string Name { get; }
        string User { get; }
        string Reason { get; }
    }
}
