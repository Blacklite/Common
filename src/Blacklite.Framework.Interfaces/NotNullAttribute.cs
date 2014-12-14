using Microsoft.Framework.Runtime;
using System;

namespace Blacklite.Framework
{
    [AssemblyNeutral]
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
    public sealed class NotNullAttribute : Attribute
    {
    }
}
