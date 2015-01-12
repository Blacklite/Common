#if ASPNET50 || ASPNETCORE50
using Microsoft.Framework.Runtime;
#endif
using System;

namespace Blacklite.Framework
{
#if ASPNET50 || ASPNETCORE50
    [AssemblyNeutral]
#endif
    public enum EventType
    {
        ResetCache,
        ResetMetadata,
    }
}
