using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Blacklite.Framework.Events
{
    public class Event : IEvent
    {
        public Event(IDictionary<string, object> data = null)
        {
            Data = new ReadOnlyDictionary<string, object>(data ?? new Dictionary<string, object>());
        }

        protected T _getValue<T>(string key)
        {
            object value;
            if (Data.TryGetValue(key, out value))
            {
                return (T)value;
            }

            return default(T);
        }

        public string Category { get { return _getValue<string>(nameof(Category)); } }
        public string Type { get { return _getValue<string>(nameof(Type)); } }
        public IReadOnlyDictionary<string, object> Data { get; }
    }
}
