using System;

namespace Blacklite.Framework
{
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
    public sealed class NotNullAttribute : Attribute
    {
    }
}
