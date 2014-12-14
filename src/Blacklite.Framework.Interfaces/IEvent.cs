using System;

namespace Blacklite.Framework
{
    [AssemblyNeutral]
    public interface IEvent
    {
        string Type { get; }
        string Name { get; }
        string User { get; }
        string Reason { get; }
    }
}
