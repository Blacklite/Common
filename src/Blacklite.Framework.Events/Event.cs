using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Blacklite.Framework.Events
{
    public class Event
    {
        public Event(IDictionary<string, object> data = null)
        {
            Data = new ReadOnlyDictionary<string, object>(data ?? new Dictionary<string, object>());
        }

        public Event(IReadOnlyDictionary<string, object> data = null)
        {
            Data = data;
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

        public string Type
        {
            get
            {
                return _getValue<string>(nameof(Type));
            }
        }

        public string Name
        {
            get
            {
                return _getValue<string>(nameof(Name));
            }
        }

        public string User
        {
            get
            {
                return _getValue<string>(nameof(User));
            }
        }

        public string Reason
        {
            get
            {
                return _getValue<string>(nameof(Reason));
            }
        }

        public IReadOnlyDictionary<string, object> Data { get; }
    }
}
