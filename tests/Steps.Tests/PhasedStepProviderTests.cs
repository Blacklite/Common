using System;
using Xunit;
using Moq;
using Steps.Tests.Fixtures;
using System.Linq;
using Blacklite.Framework.Steps;
using System.Collections.Generic;

namespace Steps.Tests
{
    public class PhasedStepProviderTests
    {
        [Fact]
        public void ResolvesStepsForEachPhase()
        {
            var stepPreInit = new PhasedStepPreInit();
            var stepInit = new PhasedStepInit();
            var stepPostInit = new PhasedStepPostInit();
            var stepPreSave = new PhasedStepPreSave();
            var stepValidate = new PhasedStepValidate();
            var stepSave = new PhasedStepSave();
            var stepPostSave = new PhasedStepPostSave();
            var stepInitPhases = new PhasedStepInitPhases();
            var stepSavePhases = new PhasedStepSavePhases();
            var stepAllPhases = new PhasedStepAllPhases();
            var mockSteps = new IPhasedStep[]
            {
                stepPreInit,
                stepInit,
                stepPostInit,
                stepPreSave,
                stepValidate,
                stepSave,
                stepPostSave,
                stepInitPhases,
                stepSavePhases,
                stepAllPhases
            };

            var provider = new PhasedStepProvider<IPhasedStep, IEnumerable<IValidation>>(new PhasedStepCache<IPhasedStep, IEnumerable<IValidation>>(mockSteps));

            var steps = provider.GetStepsForPhase(StepPhases.PreInit, new object(), It.IsAny<IStepContext>());

            //Assert.Equal(3, steps.Count());

            var underlyingSteps = steps.Cast<StepDescriptor<IEnumerable<IValidation>>>().Select(x => x.Step);

            Assert.Contains(stepPreInit, underlyingSteps);
            Assert.DoesNotContain(stepInit, underlyingSteps);
            Assert.DoesNotContain(stepPostInit, underlyingSteps);
            Assert.DoesNotContain(stepPreSave, underlyingSteps);
            Assert.DoesNotContain(stepValidate, underlyingSteps);
            Assert.DoesNotContain(stepSave, underlyingSteps);
            Assert.DoesNotContain(stepPostSave, underlyingSteps);
            Assert.Contains(stepInitPhases, underlyingSteps);
            Assert.DoesNotContain(stepSavePhases, underlyingSteps);
            Assert.Contains(stepAllPhases, underlyingSteps);

            steps = provider.GetStepsForPhase(StepPhases.Init, new object(), It.IsAny<IStepContext>());

            //Assert.Equal(3, steps.Count());

            underlyingSteps = steps.Cast<StepDescriptor<IEnumerable<IValidation>>>().Select(x => x.Step);

            Assert.DoesNotContain(stepPreInit, underlyingSteps);
            Assert.Contains(stepInit, underlyingSteps);
            Assert.DoesNotContain(stepPostInit, underlyingSteps);
            Assert.DoesNotContain(stepPreSave, underlyingSteps);
            Assert.DoesNotContain(stepValidate, underlyingSteps);
            Assert.DoesNotContain(stepSave, underlyingSteps);
            Assert.DoesNotContain(stepPostSave, underlyingSteps);
            Assert.Contains(stepInitPhases, underlyingSteps);
            Assert.DoesNotContain(stepSavePhases, underlyingSteps);
            Assert.Contains(stepAllPhases, underlyingSteps);

            steps = provider.GetStepsForPhase(StepPhases.PostInit, new object(), It.IsAny<IStepContext>());

            //Assert.Equal(3, steps.Count());

            underlyingSteps = steps.Cast<StepDescriptor<IEnumerable<IValidation>>>().Select(x => x.Step);

            Assert.DoesNotContain(stepPreInit, underlyingSteps);
            Assert.DoesNotContain(stepInit, underlyingSteps);
            Assert.Contains(stepPostInit, underlyingSteps);
            Assert.DoesNotContain(stepPreSave, underlyingSteps);
            Assert.DoesNotContain(stepValidate, underlyingSteps);
            Assert.DoesNotContain(stepSave, underlyingSteps);
            Assert.DoesNotContain(stepPostSave, underlyingSteps);
            Assert.Contains(stepInitPhases, underlyingSteps);
            Assert.DoesNotContain(stepSavePhases, underlyingSteps);
            Assert.Contains(stepAllPhases, underlyingSteps);

            steps = provider.GetStepsForPhase(StepPhases.PreSave, new object(), It.IsAny<IStepContext>());

            //Assert.Equal(3, steps.Count());

            underlyingSteps = steps.Cast<StepDescriptor<IEnumerable<IValidation>>>().Select(x => x.Step);

            Assert.DoesNotContain(stepPreInit, underlyingSteps);
            Assert.DoesNotContain(stepInit, underlyingSteps);
            Assert.DoesNotContain(stepPostInit, underlyingSteps);
            Assert.Contains(stepPreSave, underlyingSteps);
            Assert.DoesNotContain(stepValidate, underlyingSteps);
            Assert.DoesNotContain(stepSave, underlyingSteps);
            Assert.DoesNotContain(stepPostSave, underlyingSteps);
            Assert.DoesNotContain(stepInitPhases, underlyingSteps);
            Assert.Contains(stepSavePhases, underlyingSteps);
            Assert.Contains(stepAllPhases, underlyingSteps);

            steps = provider.GetStepsForPhase(StepPhases.Validate, new object(), It.IsAny<IStepContext>());

            //Assert.Equal(3, steps.Count());

            underlyingSteps = steps.Cast<StepDescriptor<IEnumerable<IValidation>>>().Select(x => x.Step);

            Assert.DoesNotContain(stepPreInit, underlyingSteps);
            Assert.DoesNotContain(stepInit, underlyingSteps);
            Assert.DoesNotContain(stepPostInit, underlyingSteps);
            Assert.DoesNotContain(stepPreSave, underlyingSteps);
            Assert.Contains(stepValidate, underlyingSteps);
            Assert.DoesNotContain(stepSave, underlyingSteps);
            Assert.DoesNotContain(stepPostSave, underlyingSteps);
            Assert.DoesNotContain(stepInitPhases, underlyingSteps);
            Assert.Contains(stepSavePhases, underlyingSteps);
            Assert.Contains(stepAllPhases, underlyingSteps);

            steps = provider.GetStepsForPhase(StepPhases.Save, new object(), It.IsAny<IStepContext>());

            //Assert.Equal(3, steps.Count());

            underlyingSteps = steps.Cast<StepDescriptor<IEnumerable<IValidation>>>().Select(x => x.Step);

            Assert.DoesNotContain(stepPreInit, underlyingSteps);
            Assert.DoesNotContain(stepInit, underlyingSteps);
            Assert.DoesNotContain(stepPostInit, underlyingSteps);
            Assert.DoesNotContain(stepPreSave, underlyingSteps);
            Assert.DoesNotContain(stepValidate, underlyingSteps);
            Assert.Contains(stepSave, underlyingSteps);
            Assert.DoesNotContain(stepPostSave, underlyingSteps);
            Assert.DoesNotContain(stepInitPhases, underlyingSteps);
            Assert.Contains(stepSavePhases, underlyingSteps);
            Assert.Contains(stepAllPhases, underlyingSteps);

            steps = provider.GetStepsForPhase(StepPhases.PostSave, new object(), It.IsAny<IStepContext>());

            //Assert.Equal(3, steps.Count());

            underlyingSteps = steps.Cast<StepDescriptor<IEnumerable<IValidation>>>().Select(x => x.Step);

            Assert.DoesNotContain(stepPreInit, underlyingSteps);
            Assert.DoesNotContain(stepInit, underlyingSteps);
            Assert.DoesNotContain(stepPostInit, underlyingSteps);
            Assert.DoesNotContain(stepPreSave, underlyingSteps);
            Assert.DoesNotContain(stepValidate, underlyingSteps);
            Assert.DoesNotContain(stepSave, underlyingSteps);
            Assert.Contains(stepPostSave, underlyingSteps);
            Assert.DoesNotContain(stepInitPhases, underlyingSteps);
            Assert.Contains(stepSavePhases, underlyingSteps);
            Assert.Contains(stepAllPhases, underlyingSteps);
        }

        [Fact]
        public void StepsOrderCorrectly()
        {
            var stepPreInit = new PhasedStepPreInit();
            var stepInit = new PhasedStepInit();
            var stepPostInit = new PhasedStepPostInit();
            var stepPreSave = new PhasedStepPreSave();
            var stepValidate = new PhasedStepValidate();
            var stepSave = new PhasedStepSave();
            var stepPostSave = new PhasedStepPostSave();
            var stepInitPhases = new PhasedStepInitPhases();
            var stepSavePhases = new PhasedStepSavePhases();
            var stepAllPhases = new PhasedStepAllPhases();
            var mockSteps = new IPhasedStep[]
            {
                stepPreInit,
                stepInit,
                stepPostInit,
                stepPreSave,
                stepValidate,
                stepSave,
                stepPostSave,
                stepInitPhases,
                stepSavePhases,
                stepAllPhases
            };

            var provider = new PhasedStepProvider<IPhasedStep, IEnumerable<IValidation>>(new PhasedStepCache<IPhasedStep, IEnumerable<IValidation>>(mockSteps));

            var steps = provider.GetStepsForPhase(StepPhases.PreInit, new object(), It.IsAny<IStepContext>()).Cast<StepDescriptor<IEnumerable<IValidation>>>().Select(x => x.Step).ToArray();

            Assert.Same(steps[0], stepInitPhases);
            Assert.Same(steps[1], stepAllPhases);
            Assert.Same(steps[2], stepPreInit);

            steps = provider.GetStepsForPhase(StepPhases.Init, new object(), It.IsAny<IStepContext>()).Cast<StepDescriptor<IEnumerable<IValidation>>>().Select(x => x.Step).ToArray();

            Assert.Same(steps[0], stepInit);
            Assert.Same(steps[1], stepInitPhases);
            Assert.Same(steps[2], stepAllPhases);

            steps = provider.GetStepsForPhase(StepPhases.PostInit, new object(), It.IsAny<IStepContext>()).Cast<StepDescriptor<IEnumerable<IValidation>>>().Select(x => x.Step).ToArray();

            Assert.Same(steps[0], stepInitPhases);
            Assert.Same(steps[1], stepPostInit);
            Assert.Same(steps[2], stepAllPhases);

            steps = provider.GetStepsForPhase(StepPhases.PreSave, new object(), It.IsAny<IStepContext>()).Cast<StepDescriptor<IEnumerable<IValidation>>>().Select(x => x.Step).ToArray();

            Assert.Same(steps[0], stepSavePhases);
            Assert.Same(steps[1], stepPreSave);
            Assert.Same(steps[2], stepAllPhases);

            steps = provider.GetStepsForPhase(StepPhases.Validate, new object(), It.IsAny<IStepContext>()).Cast<StepDescriptor<IEnumerable<IValidation>>>().Select(x => x.Step).ToArray();

            Assert.Same(steps[0], stepSavePhases);
            Assert.Same(steps[1], stepValidate);
            Assert.Same(steps[2], stepAllPhases);

            steps = provider.GetStepsForPhase(StepPhases.Save, new object(), It.IsAny<IStepContext>()).Cast<StepDescriptor<IEnumerable<IValidation>>>().Select(x => x.Step).ToArray();

            Assert.Same(steps[0], stepSavePhases);
            Assert.Same(steps[1], stepSave);
            Assert.Same(steps[2], stepAllPhases);

            steps = provider.GetStepsForPhase(StepPhases.PostSave, new object(), It.IsAny<IStepContext>()).Cast<StepDescriptor<IEnumerable<IValidation>>>().Select(x => x.Step).ToArray();

            Assert.Same(steps[0], stepPostSave);
            Assert.Same(steps[1], stepSavePhases);
            Assert.Same(steps[2], stepAllPhases);
        }

        [Fact]
        public void StepsExecuteProperty()
        {

            var context = new object();
            var processContextMock = new Mock<IStepContext>();
            var processContext = processContextMock.Object;

            var serviceProviderMock = new Mock<IServiceProvider>();
            var serviceProvider = serviceProviderMock.Object;

            var injectableMock = new Mock<IInjectable>();
            var injectable = injectableMock.Object;

            serviceProviderMock.Setup(x => x.GetService(typeof(IInjectable))).Returns(injectableMock.Object);
            processContextMock.SetupGet(x => x.ProcessServices).Returns(serviceProviderMock.Object);

            var voidExecuteMock = new Mock<PhasedStepVoidExecute>();
            var voidExecuteContextMock = new Mock<PhasedStepVoidExecuteContext>();
            var voidExecuteInjectableMock = new Mock<PhasedStepVoidExecuteInjectable>();
            voidExecuteMock.Setup(x => x.Execute(context));
            voidExecuteMock.SetupGet(x => x.Phases).Returns(StepPhases.Init);
            voidExecuteMock.Setup(x => x.CanRun(It.IsAny<Type>())).Returns(true);
            voidExecuteMock.Setup(x => x.CanExecute(context, processContext)).Returns(true);

            voidExecuteContextMock.Setup(x => x.Execute(context, processContext));
            voidExecuteContextMock.SetupGet(x => x.Phases).Returns(StepPhases.Init);
            voidExecuteContextMock.Setup(x => x.CanRun(It.IsAny<Type>())).Returns(true);
            voidExecuteContextMock.Setup(x => x.CanExecute(context, processContext)).Returns(true);

            voidExecuteInjectableMock.Setup(x => x.Execute(context, processContext, injectable));
            voidExecuteInjectableMock.SetupGet(x => x.Phases).Returns(StepPhases.Init);
            voidExecuteInjectableMock.Setup(x => x.CanRun(It.IsAny<Type>())).Returns(true);
            voidExecuteInjectableMock.Setup(x => x.CanExecute(context, processContext)).Returns(true);


            var validationExecuteMock = new Mock<PhasedStepValidationExecute>();
            var validationExecuteContextMock = new Mock<PhasedStepValidationExecuteContext>();
            var validationExecuteInjectableMock = new Mock<PhasedStepValidationExecuteInjectable>();
            validationExecuteMock.Setup(x => x.Execute(context));
            validationExecuteMock.SetupGet(x => x.Phases).Returns(StepPhases.Init);
            validationExecuteMock.Setup(x => x.CanRun(It.IsAny<Type>())).Returns(true);
            validationExecuteMock.Setup(x => x.CanExecute(It.IsAny<object>(), It.IsAny<IStepContext>())).Returns(true);

            validationExecuteContextMock.Setup(x => x.Execute(context, processContext));
            validationExecuteContextMock.SetupGet(x => x.Phases).Returns(StepPhases.Init);
            validationExecuteContextMock.Setup(x => x.CanRun(It.IsAny<Type>())).Returns(true);
            validationExecuteContextMock.Setup(x => x.CanExecute(It.IsAny<object>(), It.IsAny<IStepContext>())).Returns(true);

            validationExecuteInjectableMock.Setup(x => x.Execute(context, processContext, injectable));
            validationExecuteInjectableMock.SetupGet(x => x.Phases).Returns(StepPhases.Init);
            validationExecuteInjectableMock.Setup(x => x.CanRun(It.IsAny<Type>())).Returns(true);
            validationExecuteInjectableMock.Setup(x => x.CanExecute(It.IsAny<object>(), It.IsAny<IStepContext>())).Returns(true);

            var mockSteps = new IPhasedStep[]
            {
                voidExecuteMock.Object,
                voidExecuteContextMock.Object,
                voidExecuteInjectableMock.Object,
                validationExecuteMock.Object,
                validationExecuteContextMock.Object,
                validationExecuteInjectableMock.Object
            };

            var provider = new PhasedStepProvider<IPhasedStep, IEnumerable<IValidation>>(new PhasedStepCache<IPhasedStep, IEnumerable<IValidation>>(mockSteps));

            var steps = provider.GetStepsForPhase(StepPhases.Init, context, processContext);

            foreach (var step in steps)
            {
                step.Execute(serviceProvider, context, processContext);
            }

            voidExecuteMock.Verify(x => x.Execute(context));
            voidExecuteContextMock.Verify(x => x.Execute(context, processContext));
            voidExecuteInjectableMock.Verify(x => x.Execute(context, processContext, injectable));

            validationExecuteMock.Verify(x => x.Execute(context));
            validationExecuteContextMock.Verify(x => x.Execute(context, processContext));
            validationExecuteInjectableMock.Verify(x => x.Execute(context, processContext, injectable));
        }

        [Fact]
        public void StepsSupportsVariableCanExecuteDefinitions()
        {

            var context = new object();
            var processContextMock = new Mock<IStepContext>();
            var processContext = processContextMock.Object;

            var serviceProviderMock = new Mock<IServiceProvider>();
            var serviceProvider = serviceProviderMock.Object;

            var injectableMock = new Mock<IInjectable>();
            var injectable = injectableMock.Object;

            serviceProviderMock.Setup(x => x.GetService(typeof(IInjectable))).Returns(injectableMock.Object);
            processContextMock.SetupGet(x => x.ProcessServices).Returns(serviceProviderMock.Object);

            var customStepCanExecute = new Mock<CustomPhasedStepCanExecute>();
            var customStepCanExecuteContext = new Mock<CustomPhasedStepCanExecuteContext>();
            var customStepCanExecuteContext2 = new Mock<CustomPhasedStepCanExecuteContext2>();
            customStepCanExecute.SetupGet(x => x.Phases).Returns(StepPhases.Init);
            customStepCanExecute.Setup(x => x.CanRun(It.IsAny<Type>())).Returns(true);
            customStepCanExecute.Setup(x => x.CanExecute(context)).Returns(true);
            customStepCanExecute.Setup(x => x.Execute(context)).Returns(Enumerable.Empty<IValidation>());

            customStepCanExecuteContext.SetupGet(x => x.Phases).Returns(StepPhases.Init);
            customStepCanExecuteContext.Setup(x => x.CanRun(It.IsAny<Type>())).Returns(true);
            customStepCanExecuteContext.Setup(x => x.CanExecute(It.IsAny<IStepContext>(), context)).Returns(true);
            customStepCanExecuteContext.Setup(x => x.Execute(context)).Returns(Enumerable.Empty<IValidation>());

            customStepCanExecuteContext2.SetupGet(x => x.Phases).Returns(StepPhases.Init);
            customStepCanExecuteContext2.Setup(x => x.CanRun(It.IsAny<Type>())).Returns(true);
            customStepCanExecuteContext2.Setup(x => x.CanExecute(context, It.IsAny<IStepContext>())).Returns(true);
            customStepCanExecuteContext2.Setup(x => x.Execute(context)).Returns(Enumerable.Empty<IValidation>());

            var mockSteps = new IPhasedStep[]
            {
                customStepCanExecute.Object,
                customStepCanExecuteContext.Object,
                customStepCanExecuteContext2.Object,
            };

            var provider = new PhasedStepProvider<IPhasedStep, IEnumerable<IValidation>>(new PhasedStepCache<IPhasedStep, IEnumerable<IValidation>>(mockSteps));

            var steps = provider.GetStepsForPhase(StepPhases.Init, context, processContext).ToArray();

            customStepCanExecute.Verify(x => x.CanExecute(context));
            customStepCanExecuteContext.Verify(x => x.CanExecute(processContext, context));
            customStepCanExecuteContext2.Verify(x => x.CanExecute(context, processContext));
        }

        [Fact]
        public void DetectsCyclicDependencies()
        {
            IPhasedStep[] mockSteps;

            mockSteps = new IPhasedStep[]
            {
                new PhasedCyclicBefore1StepA(),
                new PhasedCyclicBefore1StepB(),
            };

            Assert.Throws(typeof(NotSupportedException), () => new PhasedStepProvider<IPhasedStep, IEnumerable<IValidation>>(new PhasedStepCache<IPhasedStep, IEnumerable<IValidation>>(mockSteps)));

            mockSteps = new IPhasedStep[]
            {
                new PhasedCyclicBefore2StepA(),
                new PhasedCyclicBefore2StepB(),
                new PhasedCyclicBefore2StepC(),
            };

            Assert.Throws(typeof(NotSupportedException), () => new PhasedStepProvider<IPhasedStep, IEnumerable<IValidation>>(new PhasedStepCache<IPhasedStep, IEnumerable<IValidation>>(mockSteps)));

            mockSteps = new IPhasedStep[]
            {
                new PhasedCyclicAfter1StepA(),
                new PhasedCyclicAfter1StepB(),
            };

            Assert.Throws(typeof(NotSupportedException), () => new PhasedStepProvider<IPhasedStep, IEnumerable<IValidation>>(new PhasedStepCache<IPhasedStep, IEnumerable<IValidation>>(mockSteps)));

            mockSteps = new IPhasedStep[]
            {
                new PhasedCyclicAfter2StepA(),
                new PhasedCyclicAfter2StepB(),
                new PhasedCyclicAfter2StepC(),
            };

            Assert.Throws(typeof(NotSupportedException), () => new PhasedStepProvider<IPhasedStep, IEnumerable<IValidation>>(new PhasedStepCache<IPhasedStep, IEnumerable<IValidation>>(mockSteps)));

            mockSteps = new IPhasedStep[]
            {
                new PhasedCyclicBeforeAfterStep1StepA(),
                new PhasedCyclicBeforeAfterStep1StepB(),
                new PhasedCyclicBeforeAfterStep1StepC(),
            };

            Assert.Throws(typeof(NotSupportedException), () => new PhasedStepProvider<IPhasedStep, IEnumerable<IValidation>>(new PhasedStepCache<IPhasedStep, IEnumerable<IValidation>>(mockSteps)));
        }
    }
}
