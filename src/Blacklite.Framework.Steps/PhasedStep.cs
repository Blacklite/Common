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

    public static class StepPhases
    {
        static StepPhases()
        {
            PreInit = new StepPhase(nameof(PreInit), 0, nameof(Init));
            Init = new StepPhase(nameof(Init), 1, nameof(Init));
            PostInit = new StepPhase(nameof(PostInit), 2, nameof(Init));
            InitPhases = PreInit.Union(Init).Union(PostInit);

            PreSave = new StepPhase(nameof(PreSave), 0, nameof(Save));
            Validate = new StepPhase(nameof(Validate), 1, nameof(Save));
            Save = new StepPhase(nameof(Save), 2, nameof(Save));
            PostSave = new StepPhase(nameof(PostSave), 3, nameof(Save));
            SavePhases = PreSave.Union(Validate).Union(Save).Union(PostSave);

            AllPhases = InitPhases.Union(SavePhases);
        }

        public static StepPhase PreInit { get; }
        public static StepPhase Init { get; }
        public static StepPhase PostInit { get; }
        public static IEnumerable<IStepPhase> InitPhases { get; }

        public static StepPhase PreSave { get; }
        public static StepPhase Validate { get; }
        public static StepPhase Save { get; }
        public static StepPhase PostSave { get; }

        public static IEnumerable<IStepPhase> SavePhases { get; }

        public static IEnumerable<IStepPhase> AllPhases { get; }
    }
}
