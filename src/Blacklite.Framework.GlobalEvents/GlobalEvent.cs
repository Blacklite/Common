using System;
using System.Collections.Generic;
using System.Reflection;

namespace Blacklite.Framework.GlobalEvents
{
    public class GlobalEvent : IEvent
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public string Reason { get; set; }

        public string User { get; set; }
    }
}
