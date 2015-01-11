using System;
using System.Collections.Generic;
using System.Linq;

namespace Blacklite.Framework.Steps
{
    public interface IPhasedStep : IStep
    {
        IEnumerable<IStepPhase> Phases { get; }
    }

    /// <summary>
    /// A generic step interface that implements a Typed version of CanExecute, and filters the step based on the Type of T.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class PhasedStep<T> : Step<T>, IPhasedStep
        where T : class
    {
        public abstract IEnumerable<IStepPhase> Phases { get; }
    }
}
