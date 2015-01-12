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

    public abstract class StepCache<TStep, TReturn> : IStepCache<TStep, TReturn>
        where TStep : IStep
    {
        private IStepContainer<TReturn> _cache;

        public StepCache(IEnumerable<TStep> steps) { }

        public IEnumerable<IStepDescriptor<TReturn>> BuildStepDescriptors(IEnumerable<TStep> steps) => steps.GetStepDescriptors<TStep, TReturn>();

        public void ResetCache(IEnumerable<IStepDescriptor<TReturn>> descriptors)
        {
            _cache = new StepContainer<TReturn>(descriptors);
        }

        public IEnumerator<IStepDescriptor<TReturn>> GetEnumerator() => _cache.GetEnumerator();

        public IEnumerable<IStepDescriptor<TReturn>> GetStepsForContext<T>(T context) => _cache.GetStepsForContext<T>(context);

        public IEnumerable<IStepDescriptor<TReturn>> GetStepsForContextType(Type type) => _cache.GetStepsForContext(type);

        IEnumerator IEnumerable.GetEnumerator() => _cache.GetEnumerator();
    }

    class DefaultStepCache<TStep, TReturn> : StepCache<TStep, TReturn>
        where TStep : IStep
    {
        private IStepContainer<TReturn> _cache;

        public DefaultStepCache(IEnumerable<TStep> steps) : base(steps)
        {
            ResetCache(BuildStepDescriptors(steps));
        }
    }
}
