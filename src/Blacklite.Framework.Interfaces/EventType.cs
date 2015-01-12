﻿#if aspnet50 || aspnetcore50
using Microsoft.Framework.Runtime;
#endif
using System;

namespace Blacklite.Framework
{
#if aspnet50 || aspnetcore50
    [AssemblyNeutral]
#endif
    public enum EventType
    {
        ResetCache,
        ResetMetadata,
    }
}
