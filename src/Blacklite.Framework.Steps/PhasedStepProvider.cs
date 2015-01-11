using System;
using System.Collections.Generic;
using System.Linq;

namespace Blacklite.Framework.Steps
{
    public interface IPhasedStepProvider<TStep, TReturn>
           where TStep : IPhasedStep
    {
        /// <summary>
        /// Get a list of all steps for the given phase
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="phase"></param>
        /// <param name="instance"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        IEnumerable<IStepDescriptor<TReturn>> GetStepsForPhase<T>([NotNull]IStepPhase phase, [NotNull] T instance, [NotNull]IStepContext context) where T : class;
    }

    public class PhasedStepProvider<TStep, TReturn> : IPhasedStepProvider<TStep, TReturn>
        where TStep : IPhasedStep
    {
        protected IPhasedStepCache<TStep, TReturn> _stepCache { get; }

        public PhasedStepProvider(IPhasedStepCache<TStep, TReturn> stepCache)
        {
            _stepCache = stepCache;
        }

        public IEnumerable<IStepDescriptor<TReturn>> GetStepsForPhase<T>(IStepPhase phase, [NotNull]T instance, IStepContext context)
            where T : class
        {
            IStepContainer<TReturn> value;
            if (_stepCache.TryGetValue(phase, out value))
                return value.GetStepsForContext(instance)
                    // Overrides are process steps that derive from the given step
                    // If they "CanExecute" then this step, by it's nature should not execute.
                    // because the "override" will also be in the list of possible steps for a given type.
                    // and we should not run the same step more than once.
                    .Where(step => step.CanExecute(context, instance));

            return Enumerable.Empty<IStepDescriptor<TReturn>>();
        }
    }
}
