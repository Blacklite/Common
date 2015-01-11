using Blacklite.Framework.TopographicalSort;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Blacklite.Framework.Steps
{
    public interface IStepCache<TStep, TReturn> : IStepContainer<TReturn>
        where TStep : IStep
    {
    }

    class StepCache<TStep, TReturn> : IStepCache<TStep, TReturn>
        where TStep : IStep
    {
        private readonly IStepContainer<TReturn> _cache;

        public StepCache(IEnumerable<TStep> steps)
        {
            _cache = new StepContainer<TReturn>(steps.GetStepDescriptors<TStep, TReturn>());
        }

        public IEnumerator<IStepDescriptor<TReturn>> GetEnumerator() => _cache.GetEnumerator();

        public IEnumerable<IStepDescriptor<TReturn>> GetStepsForContext<T>(T context) => _cache.GetStepsForContext<T>(context);

        public IEnumerable<IStepDescriptor<TReturn>> GetStepsForContextType(Type type) => _cache.GetStepsForContext(type);

        IEnumerator IEnumerable.GetEnumerator() => _cache.GetEnumerator();
    }
}
