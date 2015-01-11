using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Blacklite.Framework.Steps
{
    public interface IPhasedStepCache<TStep, TReturn> : IReadOnlyDictionary<IStepPhase, IStepContainer<TReturn>>
        where TStep : IStep
    {
    }

    public class PhasedStepCache<TStep, TReturn> : IPhasedStepCache<TStep, TReturn>
        where TStep : IStep
    {
        private readonly IReadOnlyDictionary<IStepPhase, IStepContainer<TReturn>> _cache;

        public PhasedStepCache(IEnumerable<TStep> steps)
        {
            var sortedSteps = steps.GetStepDescriptors<TStep, TReturn>()
                    // Select all the descitptors out into each of the supported phases
                    .SelectMany(x => x.Phases, (d, p) => new { Phase = p, Descriptor = d })
                    // Group for each phase
                    .GroupBy(x => x.Phase, x => x.Descriptor)
                    .ToDictionary(x => x.Key, x => (IStepContainer<TReturn>)new StepContainer<TReturn>(x));

            _cache = new ReadOnlyDictionary<IStepPhase, IStepContainer<TReturn>>(sortedSteps);
        }

        public IStepContainer<TReturn> this[IStepPhase key] => _cache[key];

        public int Count => _cache.Count;

        public IEnumerable<IStepPhase> Keys => _cache.Keys;

        public IEnumerable<IStepContainer<TReturn>> Values => _cache.Values;

        public bool ContainsKey(IStepPhase key) => _cache.ContainsKey(key);

        public IEnumerator<KeyValuePair<IStepPhase, IStepContainer<TReturn>>> GetEnumerator() => _cache.GetEnumerator();

        public bool TryGetValue(IStepPhase key, out IStepContainer<TReturn> value) => _cache.TryGetValue(key, out value);

        IEnumerator IEnumerable.GetEnumerator() => _cache.GetEnumerator();
    }
}
