using Blacklite.Framework.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Blacklite.Framework.GlobalEvents
{
    public interface IGlobalEvent : IEvent { }

    public class GlobalEvent : IGlobalEvent
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public string Reason { get; set; }

        public string User { get; set; }

        public IReadOnlyDictionary<string, string> Data { get; set; } = new Dictionary<string, string>();

        public static GlobalEvent Create(IEvent evt)
        {
            var globalEvent = new GlobalEvent();
            globalEvent.Type = evt.Type;
            globalEvent.Name = evt.Name;
            globalEvent.Reason = evt.Reason;
            globalEvent.User = evt.User;
            globalEvent.Data = evt.Data?.ToDictionary(x => x.Key, x => x.Value) ?? new Dictionary<string, string>();

            return globalEvent;
        }
    }
}
