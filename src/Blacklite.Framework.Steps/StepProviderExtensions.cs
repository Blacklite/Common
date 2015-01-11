using System;
using System.Collections.Generic;
using System.Linq;

namespace Blacklite.Framework.Steps
{
    //public static class StepProviderExtensions
    //{
    //    public static string Init { get; } = nameof(Init);
    //    public static string Save { get; } = nameof(Save);

    //    public static IEnumerable<IGrouping<IStepPhase, IStepDescriptor<TReturn>>> GetInitSteps<TStep, TReturn, T>(
    //        [NotNull] this IPhasedStepProvider<TStep, TReturn> provider,
    //        [NotNull] T instance,
    //        [NotNull] IStepContext context)
    //        where TStep : IPhasedStep
    //        where T : class
    //    {
    //        return provider.GetStepsForStage(Init, instance, context);
    //    }

    //    public static IEnumerable<IGrouping<IStepPhase, IStepDescriptor<TReturn>>> GetSaveSteps<TStep, TReturn, T>(
    //        [NotNull] this IPhasedStepProvider<TStep, TReturn> provider,
    //        [NotNull] T instance,
    //        [NotNull] IStepContext context)
    //        where T : class
    //        where TStep : IPhasedStep
    //    {
    //        return provider.GetStepsForStage(Save, instance, context);
    //    }
    //}
}
