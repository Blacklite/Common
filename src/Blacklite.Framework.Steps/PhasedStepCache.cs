using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Blacklite.Framework.Steps
{
    public interface IPhasedStepCache<TStep, TReturn> : IReadOnlyDictionary<IStepPhase, IStepContainer<TReturn>>
        where TStep : IPhasedStep
    {
    }

    public abstract class PhasedStepCache<TStep, TReturn> : IPhasedStepCache<TStep, TReturn>
        where TStep : IPhasedStep
    {
        private IReadOnlyDictionary<IStepPhase, IStepContainer<TReturn>> _cache;

        public PhasedStepCache(IEnumerable<TStep> steps)
        {
            var sortedSteps = steps.GetStepDescriptors<TStep, TReturn>()
                    .Cast<StepDescriptor<TReturn>>()
                    // Select all the descitptors out into each of the supported phases
                    .SelectMany(x => x.Phases, (d, p) => new { Phase = p, Descriptor = d })
                    // Group for each phase
                    .GroupBy(x => x.Phase, x => x.Descriptor)
                    .ToDictionary(x => x.Key, x => (IStepContainer<TReturn>)new StepContainer<TReturn>(x));

            _cache = new ReadOnlyDictionary<IStepPhase, IStepContainer<TReturn>>(sortedSteps);
        }

        public IEnumerable<IStepDescriptor<TReturn>> BuildStepDescriptors(IEnumerable<TStep> steps) => steps.GetStepDescriptors<TStep, TReturn>();

        public IDictionary<IStepPhase, IStepContainer<TReturn>> BuildSortedSteps(IEnumerable<IStepDescriptor<TReturn>> describers) =>
            describers
                .Cast<StepDescriptor<TReturn>>()
                // Select all the descitptors out into each of the supported phases
                .SelectMany(x => x.Phases, (d, p) => new { Phase = p, Descriptor = d })
                // Group for each phase
                .GroupBy(x => x.Phase, x => x.Descriptor)
                .ToDictionary(x => x.Key, x => (IStepContainer<TReturn>)new StepContainer<TReturn>(x));

        public void ResetCache(IDictionary<IStepPhase, IStepContainer<TReturn>> sortedSteps)
        {
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

    class DefaultPhasedStepCache<TStep, TReturn> : PhasedStepCache<TStep, TReturn>
        where TStep : IPhasedStep
    {
        private IStepContainer<TReturn> _cache;

        public DefaultPhasedStepCache(IEnumerable<TStep> steps) : base(steps)
        {
            ResetCache(BuildSortedSteps(BuildStepDescriptors(steps)));
        }
    }
}
