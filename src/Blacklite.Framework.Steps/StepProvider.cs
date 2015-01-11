using Blacklite.Framework.TopographicalSort;
using Microsoft.Framework.DependencyInjection;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;

namespace Blacklite.Framework.Steps
{
    public interface IStepProvider<TStep, TReturn>
        where TStep : IStep
    {
        /// <summary>
        /// Get a list of all steps for the given phase
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="phase"></param>
        /// <param name="instance"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        IEnumerable<IStepDescriptor<TReturn>> GetSteps<T>([NotNull]IStepContext context, [NotNull] T instance) where T : class;
    }

    public class StepProvider<TStep, TReturn> : IStepProvider<TStep, TReturn>
        where TStep : IStep
    {
        protected IStepCache<TStep, TReturn> _stepCache { get; }

        public StepProvider(IStepCache<TStep, TReturn> stepCache)
        {
            _stepCache = stepCache;
        }

        public IEnumerable<IStepDescriptor<TReturn>> GetSteps<T>([NotNull] IStepContext context, T instance)
            where T : class
        {
            return _stepCache.GetStepsForContext(instance).Where(x => x.CanExecute(context, instance));
        }
    }
}
