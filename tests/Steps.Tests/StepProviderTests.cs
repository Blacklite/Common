using System;
using Xunit;
using Moq;
using Steps.Tests.Fixtures;
using System.Linq;
using Blacklite.Framework.Steps;
using System.Collections.Generic;

namespace Steps.Tests
{
    public class StepProviderTests
    {
        [Fact]
        public void ResolvesSteps()
        {
            var stepPreInit = new StepPreInit();
            var stepInit = new StepInit();
            var stepPostInit = new StepPostInit();
            var stepPreSave = new StepPreSave();
            var stepValidate = new StepValidate();
            var stepSave = new StepSave();
            var stepPostSave = new StepPostSave();
            var stepInitPhases = new StepInitPhases();
            var stepSavePhases = new StepSavePhases();
            var stepAllPhases = new StepAllPhases();
            var mockSteps = new IStep[]
            {
                stepPreInit,
                stepInit,
                stepPostInit,
                stepPreSave,
                stepValidate,
                stepPostSave,
                stepInitPhases,
                stepAllPhases
            };

            var provider = new StepProvider<IStep, IEnumerable<IValidation>>(new StepCache<IStep, IEnumerable<IValidation>>(mockSteps));

            var steps = provider.GetSteps(new object(), It.IsAny<IStepContext>());

            //Assert.Equal(3, steps.Count());

            var underlyingSteps = steps.Cast<StepDescriptor<IEnumerable<IValidation>>>().Select(x => x.Step);

            Assert.Contains(stepPreInit, underlyingSteps);
            Assert.Contains(stepInit, underlyingSteps);
            Assert.Contains(stepPostInit, underlyingSteps);
            Assert.Contains(stepPreSave, underlyingSteps);
            Assert.Contains(stepValidate, underlyingSteps);
            Assert.DoesNotContain(stepSave, underlyingSteps);
            Assert.Contains(stepPostSave, underlyingSteps);
            Assert.Contains(stepInitPhases, underlyingSteps);
            Assert.DoesNotContain(stepSavePhases, underlyingSteps);
            Assert.Contains(stepAllPhases, underlyingSteps);
        }

        [Fact]
        public void StepsOrderCorrectly()
        {
            var stepPreInit = new StepPreInit();
            var stepInit = new StepInit();
            var stepPostInit = new StepPostInit();
            var stepPreSave = new StepPreSave();
            var stepValidate = new StepValidate();
            var stepSave = new StepSave();
            var stepPostSave = new StepPostSave();
            var stepInitPhases = new StepInitPhases();
            var stepSavePhases = new StepSavePhases();
            var stepAllPhases = new StepAllPhases();
            var mockSteps = new IStep[]
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

            var provider = new StepProvider<IStep, IEnumerable<IValidation>>(new StepCache<IStep, IEnumerable<IValidation>>(mockSteps));

            var steps = provider.GetSteps(new object(), It.IsAny<IStepContext>()).Cast<StepDescriptor<IEnumerable<IValidation>>>().Select(x => x.Step).ToArray();

            Assert.Same(steps[0], stepInit);
            Assert.Same(steps[1], stepInitPhases);
            Assert.Same(steps[2], stepPostSave);
            Assert.Same(steps[3], stepSavePhases);
            Assert.Same(steps[4], stepPostInit);
            Assert.Same(steps[5], stepPreSave);
            Assert.Same(steps[6], stepValidate);
            Assert.Same(steps[7], stepSave);
            Assert.Same(steps[8], stepAllPhases);
            Assert.Same(steps[9], stepPreInit);
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

            var voidExecuteMock = new Mock<StepVoidExecute>();
            var voidExecuteContextMock = new Mock<StepVoidExecuteContext>();
            var voidExecuteInjectableMock = new Mock<StepVoidExecuteInjectable>();
            voidExecuteMock.Setup(x => x.Execute(context));
            voidExecuteMock.Setup(x => x.CanRun(It.IsAny<Type>())).Returns(true);
            voidExecuteMock.Setup(x => x.CanExecute(context, processContext)).Returns(true);

            voidExecuteContextMock.Setup(x => x.Execute(context, processContext));
            voidExecuteContextMock.Setup(x => x.CanRun(It.IsAny<Type>())).Returns(true);
            voidExecuteContextMock.Setup(x => x.CanExecute(context, processContext)).Returns(true);

            voidExecuteInjectableMock.Setup(x => x.Execute(context, processContext, injectable));
            voidExecuteInjectableMock.Setup(x => x.CanRun(It.IsAny<Type>())).Returns(true);
            voidExecuteInjectableMock.Setup(x => x.CanExecute(context, processContext)).Returns(true);


            var validationExecuteMock = new Mock<StepValidationExecute>();
            var validationExecuteContextMock = new Mock<StepValidationExecuteContext>();
            var validationExecuteInjectableMock = new Mock<StepValidationExecuteInjectable>();
            validationExecuteMock.Setup(x => x.Execute(context));
            validationExecuteMock.Setup(x => x.CanRun(It.IsAny<Type>())).Returns(true);
            validationExecuteMock.Setup(x => x.CanExecute(It.IsAny<object>(), It.IsAny<IStepContext>())).Returns(true);

            validationExecuteContextMock.Setup(x => x.Execute(context, processContext));
            validationExecuteContextMock.Setup(x => x.CanRun(It.IsAny<Type>())).Returns(true);
            validationExecuteContextMock.Setup(x => x.CanExecute(It.IsAny<object>(), It.IsAny<IStepContext>())).Returns(true);

            validationExecuteInjectableMock.Setup(x => x.Execute(context, processContext, injectable));
            validationExecuteInjectableMock.Setup(x => x.CanRun(It.IsAny<Type>())).Returns(true);
            validationExecuteInjectableMock.Setup(x => x.CanExecute(It.IsAny<object>(), It.IsAny<IStepContext>())).Returns(true);

            var mockSteps = new IStep[]
            {
                voidExecuteMock.Object,
                voidExecuteContextMock.Object,
                voidExecuteInjectableMock.Object,
                validationExecuteMock.Object,
                validationExecuteContextMock.Object,
                validationExecuteInjectableMock.Object
            };

            var provider = new StepProvider<IStep, IEnumerable<IValidation>>(new StepCache<IStep, IEnumerable<IValidation>>(mockSteps));

            var steps = provider.GetSteps(context, processContext);

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

            var customStepCanExecute = new Mock<CustomStepCanExecute>();
            var customStepCanExecuteContext = new Mock<CustomStepCanExecuteContext>();
            var customStepCanExecuteContext2 = new Mock<CustomStepCanExecuteContext2>();
            customStepCanExecute.Setup(x => x.CanRun(It.IsAny<Type>())).Returns(true);
            customStepCanExecute.Setup(x => x.CanExecute(context)).Returns(true);
            customStepCanExecute.Setup(x => x.Execute(context)).Returns(Enumerable.Empty<IValidation>());

            customStepCanExecuteContext.Setup(x => x.CanRun(It.IsAny<Type>())).Returns(true);
            customStepCanExecuteContext.Setup(x => x.CanExecute(It.IsAny<IStepContext>(), context)).Returns(true);
            customStepCanExecuteContext.Setup(x => x.Execute(context)).Returns(Enumerable.Empty<IValidation>());

            customStepCanExecuteContext2.Setup(x => x.CanRun(It.IsAny<Type>())).Returns(true);
            customStepCanExecuteContext2.Setup(x => x.CanExecute(context, It.IsAny<IStepContext>())).Returns(true);
            customStepCanExecuteContext2.Setup(x => x.Execute(context)).Returns(Enumerable.Empty<IValidation>());

            var mockSteps = new IStep[]
            {
                customStepCanExecute.Object,
                customStepCanExecuteContext.Object,
                customStepCanExecuteContext2.Object,
            };

            var provider = new StepProvider<IStep, IEnumerable<IValidation>>(new StepCache<IStep, IEnumerable<IValidation>>(mockSteps));

            var steps = provider.GetSteps(context, processContext).ToArray();

            customStepCanExecute.Verify(x => x.CanExecute(context));
            customStepCanExecuteContext.Verify(x => x.CanExecute(processContext, context));
            customStepCanExecuteContext2.Verify(x => x.CanExecute(context, processContext));
        }

        [Fact]
        public void CanExecuteIsNotInjectable()
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

            var customStepCanExecuteInvalid = new Mock<CustomStepCanExecuteInvalid>();
            customStepCanExecuteInvalid.Setup(x => x.CanRun(It.IsAny<Type>())).Returns(true);
            customStepCanExecuteInvalid.Setup(x => x.CanExecute(context, processContext, new Mock<IInjectable>().Object)).Returns(true);

            var mockSteps = new IStep[]
            {
                customStepCanExecuteInvalid.Object,
            };

            Assert.Throws(typeof(NotSupportedException), () => new StepProvider<IStep, IEnumerable<IValidation>>(new StepCache<IStep, IEnumerable<IValidation>>(mockSteps)));
        }

        [Fact]
        public void DetectsCyclicDependencies()
        {
            IStep[] mockSteps;

            mockSteps = new IStep[]
            {
                new CyclicBefore1StepA(),
                new CyclicBefore1StepB(),
            };

            Assert.Throws(typeof(NotSupportedException), () => new StepProvider<IStep, IEnumerable<IValidation>>(new StepCache<IStep, IEnumerable<IValidation>>(mockSteps)));

            mockSteps = new IStep[]
            {
                new CyclicBefore2StepA(),
                new CyclicBefore2StepB(),
                new CyclicBefore2StepC(),
            };

            Assert.Throws(typeof(NotSupportedException), () => new StepProvider<IStep, IEnumerable<IValidation>>(new StepCache<IStep, IEnumerable<IValidation>>(mockSteps)));

            mockSteps = new IStep[]
            {
                new CyclicAfter1StepA(),
                new CyclicAfter1StepB(),
            };

            Assert.Throws(typeof(NotSupportedException), () => new StepProvider<IStep, IEnumerable<IValidation>>(new StepCache<IStep, IEnumerable<IValidation>>(mockSteps)));

            mockSteps = new IStep[]
            {
                new CyclicAfter2StepA(),
                new CyclicAfter2StepB(),
                new CyclicAfter2StepC(),
            };

            Assert.Throws(typeof(NotSupportedException), () => new StepProvider<IStep, IEnumerable<IValidation>>(new StepCache<IStep, IEnumerable<IValidation>>(mockSteps)));

            mockSteps = new IStep[]
            {
                new CyclicBeforeAfterStep1StepA(),
                new CyclicBeforeAfterStep1StepB(),
                new CyclicBeforeAfterStep1StepC(),
            };

            Assert.Throws(typeof(NotSupportedException), () => new StepProvider<IStep, IEnumerable<IValidation>>(new StepCache<IStep, IEnumerable<IValidation>>(mockSteps)));
        }
    }
}
