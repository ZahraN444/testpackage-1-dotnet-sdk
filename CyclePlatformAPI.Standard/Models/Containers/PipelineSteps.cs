// <copyright file="PipelineSteps.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace CyclePlatformAPI.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<PipelineSteps>),
        new Type[] {
            typeof(ImageSourceCreateStepCase),
            typeof(ImageCreateStepCase),
            typeof(ImageImportStepCase),
            typeof(ImagePruneStepCase),
            typeof(ImageCreateImportStepCase),
            typeof(ContainerCreateStepCase),
            typeof(ContainerStartStepCase),
            typeof(ContainerStopStepCase),
            typeof(ContainerDeleteStepCase),
            typeof(ContainerReimageStepCase),
            typeof(ContainerRestartStepCase),
            typeof(EnvironmentCreateStepCase),
            typeof(EnvironmentStartStepCase),
            typeof(EnvironmentStopStepCase),
            typeof(EnvironmentDeleteStepCase),
            typeof(EnvironmentDeploymentStartStepCase),
            typeof(EnvironmentDeploymentStopStepCase),
            typeof(EnvironmentDeploymentsTagStepCase),
            typeof(EnvironmentDeploymentsPruneStepCase),
            typeof(EnvironmentDeploymentHealthyWatchStepCase),
            typeof(StackBuildCreateStepCase),
            typeof(StackBuildGenerateStepCase),
            typeof(StackBuildDeployStepCase),
            typeof(StackPruneStepCase),
            typeof(WebhookPostStepCase),
            typeof(WebhookGetStepCase),
            typeof(SleepStepCase)
        },
        new string[] {
            "image.source.create",
            "image.create",
            "image.import",
            "images.prune",
            "image.create-import",
            "container.create",
            "container.start",
            "container.stop",
            "container.delete",
            "container.reimage",
            "container.restart",
            "environment.create",
            "environment.start",
            "environment.stop",
            "environment.delete",
            "environment.deployment.start",
            "environment.deployment.stop",
            "environment.deployments.tag",
            "environment.deployments.prune",
            "environment.deployment.healthy.watch",
            "stack.build.create",
            "stack.build.generate",
            "stack.build.deploy",
            "stack.prune",
            "webhook.post",
            "webhook.get",
            "sleep"
        },
        "action",
        true
    )]
    public abstract class PipelineSteps
    {
        /// <summary>
        /// This is ImageSourceCreateStep case.
        /// </summary>
        /// <returns>
        /// The PipelineSteps instance, wrapping the provided ImageSourceCreateStep value.
        /// </returns>
        public static PipelineSteps FromImageSourceCreateStep(ImageSourceCreateStep imageSourceCreateStep)
        {
            return new ImageSourceCreateStepCase().Set(imageSourceCreateStep);
        }

        /// <summary>
        /// This is ImageCreateStep case.
        /// </summary>
        /// <returns>
        /// The PipelineSteps instance, wrapping the provided ImageCreateStep value.
        /// </returns>
        public static PipelineSteps FromImageCreateStep(ImageCreateStep imageCreateStep)
        {
            return new ImageCreateStepCase().Set(imageCreateStep);
        }

        /// <summary>
        /// This is ImageImportStep case.
        /// </summary>
        /// <returns>
        /// The PipelineSteps instance, wrapping the provided ImageImportStep value.
        /// </returns>
        public static PipelineSteps FromImageImportStep(ImageImportStep imageImportStep)
        {
            return new ImageImportStepCase().Set(imageImportStep);
        }

        /// <summary>
        /// This is ImagePruneStep case.
        /// </summary>
        /// <returns>
        /// The PipelineSteps instance, wrapping the provided ImagePruneStep value.
        /// </returns>
        public static PipelineSteps FromImagePruneStep(ImagePruneStep imagePruneStep)
        {
            return new ImagePruneStepCase().Set(imagePruneStep);
        }

        /// <summary>
        /// This is ImageCreateImportStep case.
        /// </summary>
        /// <returns>
        /// The PipelineSteps instance, wrapping the provided ImageCreateImportStep value.
        /// </returns>
        public static PipelineSteps FromImageCreateImportStep(ImageCreateImportStep imageCreateImportStep)
        {
            return new ImageCreateImportStepCase().Set(imageCreateImportStep);
        }

        /// <summary>
        /// This is ContainerCreateStep case.
        /// </summary>
        /// <returns>
        /// The PipelineSteps instance, wrapping the provided ContainerCreateStep value.
        /// </returns>
        public static PipelineSteps FromContainerCreateStep(ContainerCreateStep containerCreateStep)
        {
            return new ContainerCreateStepCase().Set(containerCreateStep);
        }

        /// <summary>
        /// This is ContainerStartStep case.
        /// </summary>
        /// <returns>
        /// The PipelineSteps instance, wrapping the provided ContainerStartStep value.
        /// </returns>
        public static PipelineSteps FromContainerStartStep(ContainerStartStep containerStartStep)
        {
            return new ContainerStartStepCase().Set(containerStartStep);
        }

        /// <summary>
        /// This is ContainerStopStep case.
        /// </summary>
        /// <returns>
        /// The PipelineSteps instance, wrapping the provided ContainerStopStep value.
        /// </returns>
        public static PipelineSteps FromContainerStopStep(ContainerStopStep containerStopStep)
        {
            return new ContainerStopStepCase().Set(containerStopStep);
        }

        /// <summary>
        /// This is ContainerDeleteStep case.
        /// </summary>
        /// <returns>
        /// The PipelineSteps instance, wrapping the provided ContainerDeleteStep value.
        /// </returns>
        public static PipelineSteps FromContainerDeleteStep(ContainerDeleteStep containerDeleteStep)
        {
            return new ContainerDeleteStepCase().Set(containerDeleteStep);
        }

        /// <summary>
        /// This is ContainerReimageStep case.
        /// </summary>
        /// <returns>
        /// The PipelineSteps instance, wrapping the provided ContainerReimageStep value.
        /// </returns>
        public static PipelineSteps FromContainerReimageStep(ContainerReimageStep containerReimageStep)
        {
            return new ContainerReimageStepCase().Set(containerReimageStep);
        }

        /// <summary>
        /// This is ContainerRestartStep case.
        /// </summary>
        /// <returns>
        /// The PipelineSteps instance, wrapping the provided ContainerRestartStep value.
        /// </returns>
        public static PipelineSteps FromContainerRestartStep(ContainerRestartStep containerRestartStep)
        {
            return new ContainerRestartStepCase().Set(containerRestartStep);
        }

        /// <summary>
        /// This is EnvironmentCreateStep case.
        /// </summary>
        /// <returns>
        /// The PipelineSteps instance, wrapping the provided EnvironmentCreateStep value.
        /// </returns>
        public static PipelineSteps FromEnvironmentCreateStep(EnvironmentCreateStep environmentCreateStep)
        {
            return new EnvironmentCreateStepCase().Set(environmentCreateStep);
        }

        /// <summary>
        /// This is EnvironmentStartStep case.
        /// </summary>
        /// <returns>
        /// The PipelineSteps instance, wrapping the provided EnvironmentStartStep value.
        /// </returns>
        public static PipelineSteps FromEnvironmentStartStep(EnvironmentStartStep environmentStartStep)
        {
            return new EnvironmentStartStepCase().Set(environmentStartStep);
        }

        /// <summary>
        /// This is EnvironmentStopStep case.
        /// </summary>
        /// <returns>
        /// The PipelineSteps instance, wrapping the provided EnvironmentStopStep value.
        /// </returns>
        public static PipelineSteps FromEnvironmentStopStep(EnvironmentStopStep environmentStopStep)
        {
            return new EnvironmentStopStepCase().Set(environmentStopStep);
        }

        /// <summary>
        /// This is EnvironmentDeleteStep case.
        /// </summary>
        /// <returns>
        /// The PipelineSteps instance, wrapping the provided EnvironmentDeleteStep value.
        /// </returns>
        public static PipelineSteps FromEnvironmentDeleteStep(EnvironmentDeleteStep environmentDeleteStep)
        {
            return new EnvironmentDeleteStepCase().Set(environmentDeleteStep);
        }

        /// <summary>
        /// This is EnvironmentDeploymentStartStep case.
        /// </summary>
        /// <returns>
        /// The PipelineSteps instance, wrapping the provided EnvironmentDeploymentStartStep value.
        /// </returns>
        public static PipelineSteps FromEnvironmentDeploymentStartStep(EnvironmentDeploymentStartStep environmentDeploymentStartStep)
        {
            return new EnvironmentDeploymentStartStepCase().Set(environmentDeploymentStartStep);
        }

        /// <summary>
        /// This is EnvironmentDeploymentStopStep case.
        /// </summary>
        /// <returns>
        /// The PipelineSteps instance, wrapping the provided EnvironmentDeploymentStopStep value.
        /// </returns>
        public static PipelineSteps FromEnvironmentDeploymentStopStep(EnvironmentDeploymentStopStep environmentDeploymentStopStep)
        {
            return new EnvironmentDeploymentStopStepCase().Set(environmentDeploymentStopStep);
        }

        /// <summary>
        /// This is EnvironmentDeploymentsTagStep case.
        /// </summary>
        /// <returns>
        /// The PipelineSteps instance, wrapping the provided EnvironmentDeploymentsTagStep value.
        /// </returns>
        public static PipelineSteps FromEnvironmentDeploymentsTagStep(EnvironmentDeploymentsTagStep environmentDeploymentsTagStep)
        {
            return new EnvironmentDeploymentsTagStepCase().Set(environmentDeploymentsTagStep);
        }

        /// <summary>
        /// This is EnvironmentDeploymentsPruneStep case.
        /// </summary>
        /// <returns>
        /// The PipelineSteps instance, wrapping the provided EnvironmentDeploymentsPruneStep value.
        /// </returns>
        public static PipelineSteps FromEnvironmentDeploymentsPruneStep(EnvironmentDeploymentsPruneStep environmentDeploymentsPruneStep)
        {
            return new EnvironmentDeploymentsPruneStepCase().Set(environmentDeploymentsPruneStep);
        }

        /// <summary>
        /// This is EnvironmentDeploymentHealthyWatchStep case.
        /// </summary>
        /// <returns>
        /// The PipelineSteps instance, wrapping the provided EnvironmentDeploymentHealthyWatchStep value.
        /// </returns>
        public static PipelineSteps FromEnvironmentDeploymentHealthyWatchStep(EnvironmentDeploymentHealthyWatchStep environmentDeploymentHealthyWatchStep)
        {
            return new EnvironmentDeploymentHealthyWatchStepCase().Set(environmentDeploymentHealthyWatchStep);
        }

        /// <summary>
        /// This is StackBuildCreateStep case.
        /// </summary>
        /// <returns>
        /// The PipelineSteps instance, wrapping the provided StackBuildCreateStep value.
        /// </returns>
        public static PipelineSteps FromStackBuildCreateStep(StackBuildCreateStep stackBuildCreateStep)
        {
            return new StackBuildCreateStepCase().Set(stackBuildCreateStep);
        }

        /// <summary>
        /// This is StackBuildGenerateStep case.
        /// </summary>
        /// <returns>
        /// The PipelineSteps instance, wrapping the provided StackBuildGenerateStep value.
        /// </returns>
        public static PipelineSteps FromStackBuildGenerateStep(StackBuildGenerateStep stackBuildGenerateStep)
        {
            return new StackBuildGenerateStepCase().Set(stackBuildGenerateStep);
        }

        /// <summary>
        /// This is StackBuildDeployStep case.
        /// </summary>
        /// <returns>
        /// The PipelineSteps instance, wrapping the provided StackBuildDeployStep value.
        /// </returns>
        public static PipelineSteps FromStackBuildDeployStep(StackBuildDeployStep stackBuildDeployStep)
        {
            return new StackBuildDeployStepCase().Set(stackBuildDeployStep);
        }

        /// <summary>
        /// This is StackPruneStep case.
        /// </summary>
        /// <returns>
        /// The PipelineSteps instance, wrapping the provided StackPruneStep value.
        /// </returns>
        public static PipelineSteps FromStackPruneStep(StackPruneStep stackPruneStep)
        {
            return new StackPruneStepCase().Set(stackPruneStep);
        }

        /// <summary>
        /// This is WebhookPostStep case.
        /// </summary>
        /// <returns>
        /// The PipelineSteps instance, wrapping the provided WebhookPostStep value.
        /// </returns>
        public static PipelineSteps FromWebhookPostStep(WebhookPostStep webhookPostStep)
        {
            return new WebhookPostStepCase().Set(webhookPostStep);
        }

        /// <summary>
        /// This is WebhookGetStep case.
        /// </summary>
        /// <returns>
        /// The PipelineSteps instance, wrapping the provided WebhookGetStep value.
        /// </returns>
        public static PipelineSteps FromWebhookGetStep(WebhookGetStep webhookGetStep)
        {
            return new WebhookGetStepCase().Set(webhookGetStep);
        }

        /// <summary>
        /// This is SleepStep case.
        /// </summary>
        /// <returns>
        /// The PipelineSteps instance, wrapping the provided SleepStep value.
        /// </returns>
        public static PipelineSteps FromSleepStep(SleepStep sleepStep)
        {
            return new SleepStepCase().Set(sleepStep);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(
            Func<ImageSourceCreateStep, T> imageSourceCreateStep,
            Func<ImageCreateStep, T> imageCreateStep,
            Func<ImageImportStep, T> imageImportStep,
            Func<ImagePruneStep, T> imagePruneStep,
            Func<ImageCreateImportStep, T> imageCreateImportStep,
            Func<ContainerCreateStep, T> containerCreateStep,
            Func<ContainerStartStep, T> containerStartStep,
            Func<ContainerStopStep, T> containerStopStep,
            Func<ContainerDeleteStep, T> containerDeleteStep,
            Func<ContainerReimageStep, T> containerReimageStep,
            Func<ContainerRestartStep, T> containerRestartStep,
            Func<EnvironmentCreateStep, T> environmentCreateStep,
            Func<EnvironmentStartStep, T> environmentStartStep,
            Func<EnvironmentStopStep, T> environmentStopStep,
            Func<EnvironmentDeleteStep, T> environmentDeleteStep,
            Func<EnvironmentDeploymentStartStep, T> environmentDeploymentStartStep,
            Func<EnvironmentDeploymentStopStep, T> environmentDeploymentStopStep,
            Func<EnvironmentDeploymentsTagStep, T> environmentDeploymentsTagStep,
            Func<EnvironmentDeploymentsPruneStep, T> environmentDeploymentsPruneStep,
            Func<EnvironmentDeploymentHealthyWatchStep, T> environmentDeploymentHealthyWatchStep,
            Func<StackBuildCreateStep, T> stackBuildCreateStep,
            Func<StackBuildGenerateStep, T> stackBuildGenerateStep,
            Func<StackBuildDeployStep, T> stackBuildDeployStep,
            Func<StackPruneStep, T> stackPruneStep,
            Func<WebhookPostStep, T> webhookPostStep,
            Func<WebhookGetStep, T> webhookGetStep,
            Func<SleepStep, T> sleepStep);

        [JsonConverter(typeof(UnionTypeCaseConverter<ImageSourceCreateStepCase, ImageSourceCreateStep>))]
        private sealed class ImageSourceCreateStepCase : PipelineSteps, ICaseValue<ImageSourceCreateStepCase, ImageSourceCreateStep>
        {
            public ImageSourceCreateStep _value;

            public override T Match<T>(
                Func<ImageSourceCreateStep, T> imageSourceCreateStep,
                Func<ImageCreateStep, T> imageCreateStep,
                Func<ImageImportStep, T> imageImportStep,
                Func<ImagePruneStep, T> imagePruneStep,
                Func<ImageCreateImportStep, T> imageCreateImportStep,
                Func<ContainerCreateStep, T> containerCreateStep,
                Func<ContainerStartStep, T> containerStartStep,
                Func<ContainerStopStep, T> containerStopStep,
                Func<ContainerDeleteStep, T> containerDeleteStep,
                Func<ContainerReimageStep, T> containerReimageStep,
                Func<ContainerRestartStep, T> containerRestartStep,
                Func<EnvironmentCreateStep, T> environmentCreateStep,
                Func<EnvironmentStartStep, T> environmentStartStep,
                Func<EnvironmentStopStep, T> environmentStopStep,
                Func<EnvironmentDeleteStep, T> environmentDeleteStep,
                Func<EnvironmentDeploymentStartStep, T> environmentDeploymentStartStep,
                Func<EnvironmentDeploymentStopStep, T> environmentDeploymentStopStep,
                Func<EnvironmentDeploymentsTagStep, T> environmentDeploymentsTagStep,
                Func<EnvironmentDeploymentsPruneStep, T> environmentDeploymentsPruneStep,
                Func<EnvironmentDeploymentHealthyWatchStep, T> environmentDeploymentHealthyWatchStep,
                Func<StackBuildCreateStep, T> stackBuildCreateStep,
                Func<StackBuildGenerateStep, T> stackBuildGenerateStep,
                Func<StackBuildDeployStep, T> stackBuildDeployStep,
                Func<StackPruneStep, T> stackPruneStep,
                Func<WebhookPostStep, T> webhookPostStep,
                Func<WebhookGetStep, T> webhookGetStep,
                Func<SleepStep, T> sleepStep)
            {
                return imageSourceCreateStep(_value);
            }

            public ImageSourceCreateStepCase Set(ImageSourceCreateStep value)
            {
                _value = value;
                return this;
            }

            public ImageSourceCreateStep Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ImageCreateStepCase, ImageCreateStep>))]
        private sealed class ImageCreateStepCase : PipelineSteps, ICaseValue<ImageCreateStepCase, ImageCreateStep>
        {
            public ImageCreateStep _value;

            public override T Match<T>(
                Func<ImageSourceCreateStep, T> imageSourceCreateStep,
                Func<ImageCreateStep, T> imageCreateStep,
                Func<ImageImportStep, T> imageImportStep,
                Func<ImagePruneStep, T> imagePruneStep,
                Func<ImageCreateImportStep, T> imageCreateImportStep,
                Func<ContainerCreateStep, T> containerCreateStep,
                Func<ContainerStartStep, T> containerStartStep,
                Func<ContainerStopStep, T> containerStopStep,
                Func<ContainerDeleteStep, T> containerDeleteStep,
                Func<ContainerReimageStep, T> containerReimageStep,
                Func<ContainerRestartStep, T> containerRestartStep,
                Func<EnvironmentCreateStep, T> environmentCreateStep,
                Func<EnvironmentStartStep, T> environmentStartStep,
                Func<EnvironmentStopStep, T> environmentStopStep,
                Func<EnvironmentDeleteStep, T> environmentDeleteStep,
                Func<EnvironmentDeploymentStartStep, T> environmentDeploymentStartStep,
                Func<EnvironmentDeploymentStopStep, T> environmentDeploymentStopStep,
                Func<EnvironmentDeploymentsTagStep, T> environmentDeploymentsTagStep,
                Func<EnvironmentDeploymentsPruneStep, T> environmentDeploymentsPruneStep,
                Func<EnvironmentDeploymentHealthyWatchStep, T> environmentDeploymentHealthyWatchStep,
                Func<StackBuildCreateStep, T> stackBuildCreateStep,
                Func<StackBuildGenerateStep, T> stackBuildGenerateStep,
                Func<StackBuildDeployStep, T> stackBuildDeployStep,
                Func<StackPruneStep, T> stackPruneStep,
                Func<WebhookPostStep, T> webhookPostStep,
                Func<WebhookGetStep, T> webhookGetStep,
                Func<SleepStep, T> sleepStep)
            {
                return imageCreateStep(_value);
            }

            public ImageCreateStepCase Set(ImageCreateStep value)
            {
                _value = value;
                return this;
            }

            public ImageCreateStep Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ImageImportStepCase, ImageImportStep>))]
        private sealed class ImageImportStepCase : PipelineSteps, ICaseValue<ImageImportStepCase, ImageImportStep>
        {
            public ImageImportStep _value;

            public override T Match<T>(
                Func<ImageSourceCreateStep, T> imageSourceCreateStep,
                Func<ImageCreateStep, T> imageCreateStep,
                Func<ImageImportStep, T> imageImportStep,
                Func<ImagePruneStep, T> imagePruneStep,
                Func<ImageCreateImportStep, T> imageCreateImportStep,
                Func<ContainerCreateStep, T> containerCreateStep,
                Func<ContainerStartStep, T> containerStartStep,
                Func<ContainerStopStep, T> containerStopStep,
                Func<ContainerDeleteStep, T> containerDeleteStep,
                Func<ContainerReimageStep, T> containerReimageStep,
                Func<ContainerRestartStep, T> containerRestartStep,
                Func<EnvironmentCreateStep, T> environmentCreateStep,
                Func<EnvironmentStartStep, T> environmentStartStep,
                Func<EnvironmentStopStep, T> environmentStopStep,
                Func<EnvironmentDeleteStep, T> environmentDeleteStep,
                Func<EnvironmentDeploymentStartStep, T> environmentDeploymentStartStep,
                Func<EnvironmentDeploymentStopStep, T> environmentDeploymentStopStep,
                Func<EnvironmentDeploymentsTagStep, T> environmentDeploymentsTagStep,
                Func<EnvironmentDeploymentsPruneStep, T> environmentDeploymentsPruneStep,
                Func<EnvironmentDeploymentHealthyWatchStep, T> environmentDeploymentHealthyWatchStep,
                Func<StackBuildCreateStep, T> stackBuildCreateStep,
                Func<StackBuildGenerateStep, T> stackBuildGenerateStep,
                Func<StackBuildDeployStep, T> stackBuildDeployStep,
                Func<StackPruneStep, T> stackPruneStep,
                Func<WebhookPostStep, T> webhookPostStep,
                Func<WebhookGetStep, T> webhookGetStep,
                Func<SleepStep, T> sleepStep)
            {
                return imageImportStep(_value);
            }

            public ImageImportStepCase Set(ImageImportStep value)
            {
                _value = value;
                return this;
            }

            public ImageImportStep Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ImagePruneStepCase, ImagePruneStep>))]
        private sealed class ImagePruneStepCase : PipelineSteps, ICaseValue<ImagePruneStepCase, ImagePruneStep>
        {
            public ImagePruneStep _value;

            public override T Match<T>(
                Func<ImageSourceCreateStep, T> imageSourceCreateStep,
                Func<ImageCreateStep, T> imageCreateStep,
                Func<ImageImportStep, T> imageImportStep,
                Func<ImagePruneStep, T> imagePruneStep,
                Func<ImageCreateImportStep, T> imageCreateImportStep,
                Func<ContainerCreateStep, T> containerCreateStep,
                Func<ContainerStartStep, T> containerStartStep,
                Func<ContainerStopStep, T> containerStopStep,
                Func<ContainerDeleteStep, T> containerDeleteStep,
                Func<ContainerReimageStep, T> containerReimageStep,
                Func<ContainerRestartStep, T> containerRestartStep,
                Func<EnvironmentCreateStep, T> environmentCreateStep,
                Func<EnvironmentStartStep, T> environmentStartStep,
                Func<EnvironmentStopStep, T> environmentStopStep,
                Func<EnvironmentDeleteStep, T> environmentDeleteStep,
                Func<EnvironmentDeploymentStartStep, T> environmentDeploymentStartStep,
                Func<EnvironmentDeploymentStopStep, T> environmentDeploymentStopStep,
                Func<EnvironmentDeploymentsTagStep, T> environmentDeploymentsTagStep,
                Func<EnvironmentDeploymentsPruneStep, T> environmentDeploymentsPruneStep,
                Func<EnvironmentDeploymentHealthyWatchStep, T> environmentDeploymentHealthyWatchStep,
                Func<StackBuildCreateStep, T> stackBuildCreateStep,
                Func<StackBuildGenerateStep, T> stackBuildGenerateStep,
                Func<StackBuildDeployStep, T> stackBuildDeployStep,
                Func<StackPruneStep, T> stackPruneStep,
                Func<WebhookPostStep, T> webhookPostStep,
                Func<WebhookGetStep, T> webhookGetStep,
                Func<SleepStep, T> sleepStep)
            {
                return imagePruneStep(_value);
            }

            public ImagePruneStepCase Set(ImagePruneStep value)
            {
                _value = value;
                return this;
            }

            public ImagePruneStep Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ImageCreateImportStepCase, ImageCreateImportStep>))]
        private sealed class ImageCreateImportStepCase : PipelineSteps, ICaseValue<ImageCreateImportStepCase, ImageCreateImportStep>
        {
            public ImageCreateImportStep _value;

            public override T Match<T>(
                Func<ImageSourceCreateStep, T> imageSourceCreateStep,
                Func<ImageCreateStep, T> imageCreateStep,
                Func<ImageImportStep, T> imageImportStep,
                Func<ImagePruneStep, T> imagePruneStep,
                Func<ImageCreateImportStep, T> imageCreateImportStep,
                Func<ContainerCreateStep, T> containerCreateStep,
                Func<ContainerStartStep, T> containerStartStep,
                Func<ContainerStopStep, T> containerStopStep,
                Func<ContainerDeleteStep, T> containerDeleteStep,
                Func<ContainerReimageStep, T> containerReimageStep,
                Func<ContainerRestartStep, T> containerRestartStep,
                Func<EnvironmentCreateStep, T> environmentCreateStep,
                Func<EnvironmentStartStep, T> environmentStartStep,
                Func<EnvironmentStopStep, T> environmentStopStep,
                Func<EnvironmentDeleteStep, T> environmentDeleteStep,
                Func<EnvironmentDeploymentStartStep, T> environmentDeploymentStartStep,
                Func<EnvironmentDeploymentStopStep, T> environmentDeploymentStopStep,
                Func<EnvironmentDeploymentsTagStep, T> environmentDeploymentsTagStep,
                Func<EnvironmentDeploymentsPruneStep, T> environmentDeploymentsPruneStep,
                Func<EnvironmentDeploymentHealthyWatchStep, T> environmentDeploymentHealthyWatchStep,
                Func<StackBuildCreateStep, T> stackBuildCreateStep,
                Func<StackBuildGenerateStep, T> stackBuildGenerateStep,
                Func<StackBuildDeployStep, T> stackBuildDeployStep,
                Func<StackPruneStep, T> stackPruneStep,
                Func<WebhookPostStep, T> webhookPostStep,
                Func<WebhookGetStep, T> webhookGetStep,
                Func<SleepStep, T> sleepStep)
            {
                return imageCreateImportStep(_value);
            }

            public ImageCreateImportStepCase Set(ImageCreateImportStep value)
            {
                _value = value;
                return this;
            }

            public ImageCreateImportStep Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ContainerCreateStepCase, ContainerCreateStep>))]
        private sealed class ContainerCreateStepCase : PipelineSteps, ICaseValue<ContainerCreateStepCase, ContainerCreateStep>
        {
            public ContainerCreateStep _value;

            public override T Match<T>(
                Func<ImageSourceCreateStep, T> imageSourceCreateStep,
                Func<ImageCreateStep, T> imageCreateStep,
                Func<ImageImportStep, T> imageImportStep,
                Func<ImagePruneStep, T> imagePruneStep,
                Func<ImageCreateImportStep, T> imageCreateImportStep,
                Func<ContainerCreateStep, T> containerCreateStep,
                Func<ContainerStartStep, T> containerStartStep,
                Func<ContainerStopStep, T> containerStopStep,
                Func<ContainerDeleteStep, T> containerDeleteStep,
                Func<ContainerReimageStep, T> containerReimageStep,
                Func<ContainerRestartStep, T> containerRestartStep,
                Func<EnvironmentCreateStep, T> environmentCreateStep,
                Func<EnvironmentStartStep, T> environmentStartStep,
                Func<EnvironmentStopStep, T> environmentStopStep,
                Func<EnvironmentDeleteStep, T> environmentDeleteStep,
                Func<EnvironmentDeploymentStartStep, T> environmentDeploymentStartStep,
                Func<EnvironmentDeploymentStopStep, T> environmentDeploymentStopStep,
                Func<EnvironmentDeploymentsTagStep, T> environmentDeploymentsTagStep,
                Func<EnvironmentDeploymentsPruneStep, T> environmentDeploymentsPruneStep,
                Func<EnvironmentDeploymentHealthyWatchStep, T> environmentDeploymentHealthyWatchStep,
                Func<StackBuildCreateStep, T> stackBuildCreateStep,
                Func<StackBuildGenerateStep, T> stackBuildGenerateStep,
                Func<StackBuildDeployStep, T> stackBuildDeployStep,
                Func<StackPruneStep, T> stackPruneStep,
                Func<WebhookPostStep, T> webhookPostStep,
                Func<WebhookGetStep, T> webhookGetStep,
                Func<SleepStep, T> sleepStep)
            {
                return containerCreateStep(_value);
            }

            public ContainerCreateStepCase Set(ContainerCreateStep value)
            {
                _value = value;
                return this;
            }

            public ContainerCreateStep Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ContainerStartStepCase, ContainerStartStep>))]
        private sealed class ContainerStartStepCase : PipelineSteps, ICaseValue<ContainerStartStepCase, ContainerStartStep>
        {
            public ContainerStartStep _value;

            public override T Match<T>(
                Func<ImageSourceCreateStep, T> imageSourceCreateStep,
                Func<ImageCreateStep, T> imageCreateStep,
                Func<ImageImportStep, T> imageImportStep,
                Func<ImagePruneStep, T> imagePruneStep,
                Func<ImageCreateImportStep, T> imageCreateImportStep,
                Func<ContainerCreateStep, T> containerCreateStep,
                Func<ContainerStartStep, T> containerStartStep,
                Func<ContainerStopStep, T> containerStopStep,
                Func<ContainerDeleteStep, T> containerDeleteStep,
                Func<ContainerReimageStep, T> containerReimageStep,
                Func<ContainerRestartStep, T> containerRestartStep,
                Func<EnvironmentCreateStep, T> environmentCreateStep,
                Func<EnvironmentStartStep, T> environmentStartStep,
                Func<EnvironmentStopStep, T> environmentStopStep,
                Func<EnvironmentDeleteStep, T> environmentDeleteStep,
                Func<EnvironmentDeploymentStartStep, T> environmentDeploymentStartStep,
                Func<EnvironmentDeploymentStopStep, T> environmentDeploymentStopStep,
                Func<EnvironmentDeploymentsTagStep, T> environmentDeploymentsTagStep,
                Func<EnvironmentDeploymentsPruneStep, T> environmentDeploymentsPruneStep,
                Func<EnvironmentDeploymentHealthyWatchStep, T> environmentDeploymentHealthyWatchStep,
                Func<StackBuildCreateStep, T> stackBuildCreateStep,
                Func<StackBuildGenerateStep, T> stackBuildGenerateStep,
                Func<StackBuildDeployStep, T> stackBuildDeployStep,
                Func<StackPruneStep, T> stackPruneStep,
                Func<WebhookPostStep, T> webhookPostStep,
                Func<WebhookGetStep, T> webhookGetStep,
                Func<SleepStep, T> sleepStep)
            {
                return containerStartStep(_value);
            }

            public ContainerStartStepCase Set(ContainerStartStep value)
            {
                _value = value;
                return this;
            }

            public ContainerStartStep Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ContainerStopStepCase, ContainerStopStep>))]
        private sealed class ContainerStopStepCase : PipelineSteps, ICaseValue<ContainerStopStepCase, ContainerStopStep>
        {
            public ContainerStopStep _value;

            public override T Match<T>(
                Func<ImageSourceCreateStep, T> imageSourceCreateStep,
                Func<ImageCreateStep, T> imageCreateStep,
                Func<ImageImportStep, T> imageImportStep,
                Func<ImagePruneStep, T> imagePruneStep,
                Func<ImageCreateImportStep, T> imageCreateImportStep,
                Func<ContainerCreateStep, T> containerCreateStep,
                Func<ContainerStartStep, T> containerStartStep,
                Func<ContainerStopStep, T> containerStopStep,
                Func<ContainerDeleteStep, T> containerDeleteStep,
                Func<ContainerReimageStep, T> containerReimageStep,
                Func<ContainerRestartStep, T> containerRestartStep,
                Func<EnvironmentCreateStep, T> environmentCreateStep,
                Func<EnvironmentStartStep, T> environmentStartStep,
                Func<EnvironmentStopStep, T> environmentStopStep,
                Func<EnvironmentDeleteStep, T> environmentDeleteStep,
                Func<EnvironmentDeploymentStartStep, T> environmentDeploymentStartStep,
                Func<EnvironmentDeploymentStopStep, T> environmentDeploymentStopStep,
                Func<EnvironmentDeploymentsTagStep, T> environmentDeploymentsTagStep,
                Func<EnvironmentDeploymentsPruneStep, T> environmentDeploymentsPruneStep,
                Func<EnvironmentDeploymentHealthyWatchStep, T> environmentDeploymentHealthyWatchStep,
                Func<StackBuildCreateStep, T> stackBuildCreateStep,
                Func<StackBuildGenerateStep, T> stackBuildGenerateStep,
                Func<StackBuildDeployStep, T> stackBuildDeployStep,
                Func<StackPruneStep, T> stackPruneStep,
                Func<WebhookPostStep, T> webhookPostStep,
                Func<WebhookGetStep, T> webhookGetStep,
                Func<SleepStep, T> sleepStep)
            {
                return containerStopStep(_value);
            }

            public ContainerStopStepCase Set(ContainerStopStep value)
            {
                _value = value;
                return this;
            }

            public ContainerStopStep Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ContainerDeleteStepCase, ContainerDeleteStep>))]
        private sealed class ContainerDeleteStepCase : PipelineSteps, ICaseValue<ContainerDeleteStepCase, ContainerDeleteStep>
        {
            public ContainerDeleteStep _value;

            public override T Match<T>(
                Func<ImageSourceCreateStep, T> imageSourceCreateStep,
                Func<ImageCreateStep, T> imageCreateStep,
                Func<ImageImportStep, T> imageImportStep,
                Func<ImagePruneStep, T> imagePruneStep,
                Func<ImageCreateImportStep, T> imageCreateImportStep,
                Func<ContainerCreateStep, T> containerCreateStep,
                Func<ContainerStartStep, T> containerStartStep,
                Func<ContainerStopStep, T> containerStopStep,
                Func<ContainerDeleteStep, T> containerDeleteStep,
                Func<ContainerReimageStep, T> containerReimageStep,
                Func<ContainerRestartStep, T> containerRestartStep,
                Func<EnvironmentCreateStep, T> environmentCreateStep,
                Func<EnvironmentStartStep, T> environmentStartStep,
                Func<EnvironmentStopStep, T> environmentStopStep,
                Func<EnvironmentDeleteStep, T> environmentDeleteStep,
                Func<EnvironmentDeploymentStartStep, T> environmentDeploymentStartStep,
                Func<EnvironmentDeploymentStopStep, T> environmentDeploymentStopStep,
                Func<EnvironmentDeploymentsTagStep, T> environmentDeploymentsTagStep,
                Func<EnvironmentDeploymentsPruneStep, T> environmentDeploymentsPruneStep,
                Func<EnvironmentDeploymentHealthyWatchStep, T> environmentDeploymentHealthyWatchStep,
                Func<StackBuildCreateStep, T> stackBuildCreateStep,
                Func<StackBuildGenerateStep, T> stackBuildGenerateStep,
                Func<StackBuildDeployStep, T> stackBuildDeployStep,
                Func<StackPruneStep, T> stackPruneStep,
                Func<WebhookPostStep, T> webhookPostStep,
                Func<WebhookGetStep, T> webhookGetStep,
                Func<SleepStep, T> sleepStep)
            {
                return containerDeleteStep(_value);
            }

            public ContainerDeleteStepCase Set(ContainerDeleteStep value)
            {
                _value = value;
                return this;
            }

            public ContainerDeleteStep Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ContainerReimageStepCase, ContainerReimageStep>))]
        private sealed class ContainerReimageStepCase : PipelineSteps, ICaseValue<ContainerReimageStepCase, ContainerReimageStep>
        {
            public ContainerReimageStep _value;

            public override T Match<T>(
                Func<ImageSourceCreateStep, T> imageSourceCreateStep,
                Func<ImageCreateStep, T> imageCreateStep,
                Func<ImageImportStep, T> imageImportStep,
                Func<ImagePruneStep, T> imagePruneStep,
                Func<ImageCreateImportStep, T> imageCreateImportStep,
                Func<ContainerCreateStep, T> containerCreateStep,
                Func<ContainerStartStep, T> containerStartStep,
                Func<ContainerStopStep, T> containerStopStep,
                Func<ContainerDeleteStep, T> containerDeleteStep,
                Func<ContainerReimageStep, T> containerReimageStep,
                Func<ContainerRestartStep, T> containerRestartStep,
                Func<EnvironmentCreateStep, T> environmentCreateStep,
                Func<EnvironmentStartStep, T> environmentStartStep,
                Func<EnvironmentStopStep, T> environmentStopStep,
                Func<EnvironmentDeleteStep, T> environmentDeleteStep,
                Func<EnvironmentDeploymentStartStep, T> environmentDeploymentStartStep,
                Func<EnvironmentDeploymentStopStep, T> environmentDeploymentStopStep,
                Func<EnvironmentDeploymentsTagStep, T> environmentDeploymentsTagStep,
                Func<EnvironmentDeploymentsPruneStep, T> environmentDeploymentsPruneStep,
                Func<EnvironmentDeploymentHealthyWatchStep, T> environmentDeploymentHealthyWatchStep,
                Func<StackBuildCreateStep, T> stackBuildCreateStep,
                Func<StackBuildGenerateStep, T> stackBuildGenerateStep,
                Func<StackBuildDeployStep, T> stackBuildDeployStep,
                Func<StackPruneStep, T> stackPruneStep,
                Func<WebhookPostStep, T> webhookPostStep,
                Func<WebhookGetStep, T> webhookGetStep,
                Func<SleepStep, T> sleepStep)
            {
                return containerReimageStep(_value);
            }

            public ContainerReimageStepCase Set(ContainerReimageStep value)
            {
                _value = value;
                return this;
            }

            public ContainerReimageStep Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ContainerRestartStepCase, ContainerRestartStep>))]
        private sealed class ContainerRestartStepCase : PipelineSteps, ICaseValue<ContainerRestartStepCase, ContainerRestartStep>
        {
            public ContainerRestartStep _value;

            public override T Match<T>(
                Func<ImageSourceCreateStep, T> imageSourceCreateStep,
                Func<ImageCreateStep, T> imageCreateStep,
                Func<ImageImportStep, T> imageImportStep,
                Func<ImagePruneStep, T> imagePruneStep,
                Func<ImageCreateImportStep, T> imageCreateImportStep,
                Func<ContainerCreateStep, T> containerCreateStep,
                Func<ContainerStartStep, T> containerStartStep,
                Func<ContainerStopStep, T> containerStopStep,
                Func<ContainerDeleteStep, T> containerDeleteStep,
                Func<ContainerReimageStep, T> containerReimageStep,
                Func<ContainerRestartStep, T> containerRestartStep,
                Func<EnvironmentCreateStep, T> environmentCreateStep,
                Func<EnvironmentStartStep, T> environmentStartStep,
                Func<EnvironmentStopStep, T> environmentStopStep,
                Func<EnvironmentDeleteStep, T> environmentDeleteStep,
                Func<EnvironmentDeploymentStartStep, T> environmentDeploymentStartStep,
                Func<EnvironmentDeploymentStopStep, T> environmentDeploymentStopStep,
                Func<EnvironmentDeploymentsTagStep, T> environmentDeploymentsTagStep,
                Func<EnvironmentDeploymentsPruneStep, T> environmentDeploymentsPruneStep,
                Func<EnvironmentDeploymentHealthyWatchStep, T> environmentDeploymentHealthyWatchStep,
                Func<StackBuildCreateStep, T> stackBuildCreateStep,
                Func<StackBuildGenerateStep, T> stackBuildGenerateStep,
                Func<StackBuildDeployStep, T> stackBuildDeployStep,
                Func<StackPruneStep, T> stackPruneStep,
                Func<WebhookPostStep, T> webhookPostStep,
                Func<WebhookGetStep, T> webhookGetStep,
                Func<SleepStep, T> sleepStep)
            {
                return containerRestartStep(_value);
            }

            public ContainerRestartStepCase Set(ContainerRestartStep value)
            {
                _value = value;
                return this;
            }

            public ContainerRestartStep Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<EnvironmentCreateStepCase, EnvironmentCreateStep>))]
        private sealed class EnvironmentCreateStepCase : PipelineSteps, ICaseValue<EnvironmentCreateStepCase, EnvironmentCreateStep>
        {
            public EnvironmentCreateStep _value;

            public override T Match<T>(
                Func<ImageSourceCreateStep, T> imageSourceCreateStep,
                Func<ImageCreateStep, T> imageCreateStep,
                Func<ImageImportStep, T> imageImportStep,
                Func<ImagePruneStep, T> imagePruneStep,
                Func<ImageCreateImportStep, T> imageCreateImportStep,
                Func<ContainerCreateStep, T> containerCreateStep,
                Func<ContainerStartStep, T> containerStartStep,
                Func<ContainerStopStep, T> containerStopStep,
                Func<ContainerDeleteStep, T> containerDeleteStep,
                Func<ContainerReimageStep, T> containerReimageStep,
                Func<ContainerRestartStep, T> containerRestartStep,
                Func<EnvironmentCreateStep, T> environmentCreateStep,
                Func<EnvironmentStartStep, T> environmentStartStep,
                Func<EnvironmentStopStep, T> environmentStopStep,
                Func<EnvironmentDeleteStep, T> environmentDeleteStep,
                Func<EnvironmentDeploymentStartStep, T> environmentDeploymentStartStep,
                Func<EnvironmentDeploymentStopStep, T> environmentDeploymentStopStep,
                Func<EnvironmentDeploymentsTagStep, T> environmentDeploymentsTagStep,
                Func<EnvironmentDeploymentsPruneStep, T> environmentDeploymentsPruneStep,
                Func<EnvironmentDeploymentHealthyWatchStep, T> environmentDeploymentHealthyWatchStep,
                Func<StackBuildCreateStep, T> stackBuildCreateStep,
                Func<StackBuildGenerateStep, T> stackBuildGenerateStep,
                Func<StackBuildDeployStep, T> stackBuildDeployStep,
                Func<StackPruneStep, T> stackPruneStep,
                Func<WebhookPostStep, T> webhookPostStep,
                Func<WebhookGetStep, T> webhookGetStep,
                Func<SleepStep, T> sleepStep)
            {
                return environmentCreateStep(_value);
            }

            public EnvironmentCreateStepCase Set(EnvironmentCreateStep value)
            {
                _value = value;
                return this;
            }

            public EnvironmentCreateStep Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<EnvironmentStartStepCase, EnvironmentStartStep>))]
        private sealed class EnvironmentStartStepCase : PipelineSteps, ICaseValue<EnvironmentStartStepCase, EnvironmentStartStep>
        {
            public EnvironmentStartStep _value;

            public override T Match<T>(
                Func<ImageSourceCreateStep, T> imageSourceCreateStep,
                Func<ImageCreateStep, T> imageCreateStep,
                Func<ImageImportStep, T> imageImportStep,
                Func<ImagePruneStep, T> imagePruneStep,
                Func<ImageCreateImportStep, T> imageCreateImportStep,
                Func<ContainerCreateStep, T> containerCreateStep,
                Func<ContainerStartStep, T> containerStartStep,
                Func<ContainerStopStep, T> containerStopStep,
                Func<ContainerDeleteStep, T> containerDeleteStep,
                Func<ContainerReimageStep, T> containerReimageStep,
                Func<ContainerRestartStep, T> containerRestartStep,
                Func<EnvironmentCreateStep, T> environmentCreateStep,
                Func<EnvironmentStartStep, T> environmentStartStep,
                Func<EnvironmentStopStep, T> environmentStopStep,
                Func<EnvironmentDeleteStep, T> environmentDeleteStep,
                Func<EnvironmentDeploymentStartStep, T> environmentDeploymentStartStep,
                Func<EnvironmentDeploymentStopStep, T> environmentDeploymentStopStep,
                Func<EnvironmentDeploymentsTagStep, T> environmentDeploymentsTagStep,
                Func<EnvironmentDeploymentsPruneStep, T> environmentDeploymentsPruneStep,
                Func<EnvironmentDeploymentHealthyWatchStep, T> environmentDeploymentHealthyWatchStep,
                Func<StackBuildCreateStep, T> stackBuildCreateStep,
                Func<StackBuildGenerateStep, T> stackBuildGenerateStep,
                Func<StackBuildDeployStep, T> stackBuildDeployStep,
                Func<StackPruneStep, T> stackPruneStep,
                Func<WebhookPostStep, T> webhookPostStep,
                Func<WebhookGetStep, T> webhookGetStep,
                Func<SleepStep, T> sleepStep)
            {
                return environmentStartStep(_value);
            }

            public EnvironmentStartStepCase Set(EnvironmentStartStep value)
            {
                _value = value;
                return this;
            }

            public EnvironmentStartStep Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<EnvironmentStopStepCase, EnvironmentStopStep>))]
        private sealed class EnvironmentStopStepCase : PipelineSteps, ICaseValue<EnvironmentStopStepCase, EnvironmentStopStep>
        {
            public EnvironmentStopStep _value;

            public override T Match<T>(
                Func<ImageSourceCreateStep, T> imageSourceCreateStep,
                Func<ImageCreateStep, T> imageCreateStep,
                Func<ImageImportStep, T> imageImportStep,
                Func<ImagePruneStep, T> imagePruneStep,
                Func<ImageCreateImportStep, T> imageCreateImportStep,
                Func<ContainerCreateStep, T> containerCreateStep,
                Func<ContainerStartStep, T> containerStartStep,
                Func<ContainerStopStep, T> containerStopStep,
                Func<ContainerDeleteStep, T> containerDeleteStep,
                Func<ContainerReimageStep, T> containerReimageStep,
                Func<ContainerRestartStep, T> containerRestartStep,
                Func<EnvironmentCreateStep, T> environmentCreateStep,
                Func<EnvironmentStartStep, T> environmentStartStep,
                Func<EnvironmentStopStep, T> environmentStopStep,
                Func<EnvironmentDeleteStep, T> environmentDeleteStep,
                Func<EnvironmentDeploymentStartStep, T> environmentDeploymentStartStep,
                Func<EnvironmentDeploymentStopStep, T> environmentDeploymentStopStep,
                Func<EnvironmentDeploymentsTagStep, T> environmentDeploymentsTagStep,
                Func<EnvironmentDeploymentsPruneStep, T> environmentDeploymentsPruneStep,
                Func<EnvironmentDeploymentHealthyWatchStep, T> environmentDeploymentHealthyWatchStep,
                Func<StackBuildCreateStep, T> stackBuildCreateStep,
                Func<StackBuildGenerateStep, T> stackBuildGenerateStep,
                Func<StackBuildDeployStep, T> stackBuildDeployStep,
                Func<StackPruneStep, T> stackPruneStep,
                Func<WebhookPostStep, T> webhookPostStep,
                Func<WebhookGetStep, T> webhookGetStep,
                Func<SleepStep, T> sleepStep)
            {
                return environmentStopStep(_value);
            }

            public EnvironmentStopStepCase Set(EnvironmentStopStep value)
            {
                _value = value;
                return this;
            }

            public EnvironmentStopStep Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<EnvironmentDeleteStepCase, EnvironmentDeleteStep>))]
        private sealed class EnvironmentDeleteStepCase : PipelineSteps, ICaseValue<EnvironmentDeleteStepCase, EnvironmentDeleteStep>
        {
            public EnvironmentDeleteStep _value;

            public override T Match<T>(
                Func<ImageSourceCreateStep, T> imageSourceCreateStep,
                Func<ImageCreateStep, T> imageCreateStep,
                Func<ImageImportStep, T> imageImportStep,
                Func<ImagePruneStep, T> imagePruneStep,
                Func<ImageCreateImportStep, T> imageCreateImportStep,
                Func<ContainerCreateStep, T> containerCreateStep,
                Func<ContainerStartStep, T> containerStartStep,
                Func<ContainerStopStep, T> containerStopStep,
                Func<ContainerDeleteStep, T> containerDeleteStep,
                Func<ContainerReimageStep, T> containerReimageStep,
                Func<ContainerRestartStep, T> containerRestartStep,
                Func<EnvironmentCreateStep, T> environmentCreateStep,
                Func<EnvironmentStartStep, T> environmentStartStep,
                Func<EnvironmentStopStep, T> environmentStopStep,
                Func<EnvironmentDeleteStep, T> environmentDeleteStep,
                Func<EnvironmentDeploymentStartStep, T> environmentDeploymentStartStep,
                Func<EnvironmentDeploymentStopStep, T> environmentDeploymentStopStep,
                Func<EnvironmentDeploymentsTagStep, T> environmentDeploymentsTagStep,
                Func<EnvironmentDeploymentsPruneStep, T> environmentDeploymentsPruneStep,
                Func<EnvironmentDeploymentHealthyWatchStep, T> environmentDeploymentHealthyWatchStep,
                Func<StackBuildCreateStep, T> stackBuildCreateStep,
                Func<StackBuildGenerateStep, T> stackBuildGenerateStep,
                Func<StackBuildDeployStep, T> stackBuildDeployStep,
                Func<StackPruneStep, T> stackPruneStep,
                Func<WebhookPostStep, T> webhookPostStep,
                Func<WebhookGetStep, T> webhookGetStep,
                Func<SleepStep, T> sleepStep)
            {
                return environmentDeleteStep(_value);
            }

            public EnvironmentDeleteStepCase Set(EnvironmentDeleteStep value)
            {
                _value = value;
                return this;
            }

            public EnvironmentDeleteStep Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<EnvironmentDeploymentStartStepCase, EnvironmentDeploymentStartStep>))]
        private sealed class EnvironmentDeploymentStartStepCase : PipelineSteps, ICaseValue<EnvironmentDeploymentStartStepCase, EnvironmentDeploymentStartStep>
        {
            public EnvironmentDeploymentStartStep _value;

            public override T Match<T>(
                Func<ImageSourceCreateStep, T> imageSourceCreateStep,
                Func<ImageCreateStep, T> imageCreateStep,
                Func<ImageImportStep, T> imageImportStep,
                Func<ImagePruneStep, T> imagePruneStep,
                Func<ImageCreateImportStep, T> imageCreateImportStep,
                Func<ContainerCreateStep, T> containerCreateStep,
                Func<ContainerStartStep, T> containerStartStep,
                Func<ContainerStopStep, T> containerStopStep,
                Func<ContainerDeleteStep, T> containerDeleteStep,
                Func<ContainerReimageStep, T> containerReimageStep,
                Func<ContainerRestartStep, T> containerRestartStep,
                Func<EnvironmentCreateStep, T> environmentCreateStep,
                Func<EnvironmentStartStep, T> environmentStartStep,
                Func<EnvironmentStopStep, T> environmentStopStep,
                Func<EnvironmentDeleteStep, T> environmentDeleteStep,
                Func<EnvironmentDeploymentStartStep, T> environmentDeploymentStartStep,
                Func<EnvironmentDeploymentStopStep, T> environmentDeploymentStopStep,
                Func<EnvironmentDeploymentsTagStep, T> environmentDeploymentsTagStep,
                Func<EnvironmentDeploymentsPruneStep, T> environmentDeploymentsPruneStep,
                Func<EnvironmentDeploymentHealthyWatchStep, T> environmentDeploymentHealthyWatchStep,
                Func<StackBuildCreateStep, T> stackBuildCreateStep,
                Func<StackBuildGenerateStep, T> stackBuildGenerateStep,
                Func<StackBuildDeployStep, T> stackBuildDeployStep,
                Func<StackPruneStep, T> stackPruneStep,
                Func<WebhookPostStep, T> webhookPostStep,
                Func<WebhookGetStep, T> webhookGetStep,
                Func<SleepStep, T> sleepStep)
            {
                return environmentDeploymentStartStep(_value);
            }

            public EnvironmentDeploymentStartStepCase Set(EnvironmentDeploymentStartStep value)
            {
                _value = value;
                return this;
            }

            public EnvironmentDeploymentStartStep Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<EnvironmentDeploymentStopStepCase, EnvironmentDeploymentStopStep>))]
        private sealed class EnvironmentDeploymentStopStepCase : PipelineSteps, ICaseValue<EnvironmentDeploymentStopStepCase, EnvironmentDeploymentStopStep>
        {
            public EnvironmentDeploymentStopStep _value;

            public override T Match<T>(
                Func<ImageSourceCreateStep, T> imageSourceCreateStep,
                Func<ImageCreateStep, T> imageCreateStep,
                Func<ImageImportStep, T> imageImportStep,
                Func<ImagePruneStep, T> imagePruneStep,
                Func<ImageCreateImportStep, T> imageCreateImportStep,
                Func<ContainerCreateStep, T> containerCreateStep,
                Func<ContainerStartStep, T> containerStartStep,
                Func<ContainerStopStep, T> containerStopStep,
                Func<ContainerDeleteStep, T> containerDeleteStep,
                Func<ContainerReimageStep, T> containerReimageStep,
                Func<ContainerRestartStep, T> containerRestartStep,
                Func<EnvironmentCreateStep, T> environmentCreateStep,
                Func<EnvironmentStartStep, T> environmentStartStep,
                Func<EnvironmentStopStep, T> environmentStopStep,
                Func<EnvironmentDeleteStep, T> environmentDeleteStep,
                Func<EnvironmentDeploymentStartStep, T> environmentDeploymentStartStep,
                Func<EnvironmentDeploymentStopStep, T> environmentDeploymentStopStep,
                Func<EnvironmentDeploymentsTagStep, T> environmentDeploymentsTagStep,
                Func<EnvironmentDeploymentsPruneStep, T> environmentDeploymentsPruneStep,
                Func<EnvironmentDeploymentHealthyWatchStep, T> environmentDeploymentHealthyWatchStep,
                Func<StackBuildCreateStep, T> stackBuildCreateStep,
                Func<StackBuildGenerateStep, T> stackBuildGenerateStep,
                Func<StackBuildDeployStep, T> stackBuildDeployStep,
                Func<StackPruneStep, T> stackPruneStep,
                Func<WebhookPostStep, T> webhookPostStep,
                Func<WebhookGetStep, T> webhookGetStep,
                Func<SleepStep, T> sleepStep)
            {
                return environmentDeploymentStopStep(_value);
            }

            public EnvironmentDeploymentStopStepCase Set(EnvironmentDeploymentStopStep value)
            {
                _value = value;
                return this;
            }

            public EnvironmentDeploymentStopStep Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<EnvironmentDeploymentsTagStepCase, EnvironmentDeploymentsTagStep>))]
        private sealed class EnvironmentDeploymentsTagStepCase : PipelineSteps, ICaseValue<EnvironmentDeploymentsTagStepCase, EnvironmentDeploymentsTagStep>
        {
            public EnvironmentDeploymentsTagStep _value;

            public override T Match<T>(
                Func<ImageSourceCreateStep, T> imageSourceCreateStep,
                Func<ImageCreateStep, T> imageCreateStep,
                Func<ImageImportStep, T> imageImportStep,
                Func<ImagePruneStep, T> imagePruneStep,
                Func<ImageCreateImportStep, T> imageCreateImportStep,
                Func<ContainerCreateStep, T> containerCreateStep,
                Func<ContainerStartStep, T> containerStartStep,
                Func<ContainerStopStep, T> containerStopStep,
                Func<ContainerDeleteStep, T> containerDeleteStep,
                Func<ContainerReimageStep, T> containerReimageStep,
                Func<ContainerRestartStep, T> containerRestartStep,
                Func<EnvironmentCreateStep, T> environmentCreateStep,
                Func<EnvironmentStartStep, T> environmentStartStep,
                Func<EnvironmentStopStep, T> environmentStopStep,
                Func<EnvironmentDeleteStep, T> environmentDeleteStep,
                Func<EnvironmentDeploymentStartStep, T> environmentDeploymentStartStep,
                Func<EnvironmentDeploymentStopStep, T> environmentDeploymentStopStep,
                Func<EnvironmentDeploymentsTagStep, T> environmentDeploymentsTagStep,
                Func<EnvironmentDeploymentsPruneStep, T> environmentDeploymentsPruneStep,
                Func<EnvironmentDeploymentHealthyWatchStep, T> environmentDeploymentHealthyWatchStep,
                Func<StackBuildCreateStep, T> stackBuildCreateStep,
                Func<StackBuildGenerateStep, T> stackBuildGenerateStep,
                Func<StackBuildDeployStep, T> stackBuildDeployStep,
                Func<StackPruneStep, T> stackPruneStep,
                Func<WebhookPostStep, T> webhookPostStep,
                Func<WebhookGetStep, T> webhookGetStep,
                Func<SleepStep, T> sleepStep)
            {
                return environmentDeploymentsTagStep(_value);
            }

            public EnvironmentDeploymentsTagStepCase Set(EnvironmentDeploymentsTagStep value)
            {
                _value = value;
                return this;
            }

            public EnvironmentDeploymentsTagStep Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<EnvironmentDeploymentsPruneStepCase, EnvironmentDeploymentsPruneStep>))]
        private sealed class EnvironmentDeploymentsPruneStepCase : PipelineSteps, ICaseValue<EnvironmentDeploymentsPruneStepCase, EnvironmentDeploymentsPruneStep>
        {
            public EnvironmentDeploymentsPruneStep _value;

            public override T Match<T>(
                Func<ImageSourceCreateStep, T> imageSourceCreateStep,
                Func<ImageCreateStep, T> imageCreateStep,
                Func<ImageImportStep, T> imageImportStep,
                Func<ImagePruneStep, T> imagePruneStep,
                Func<ImageCreateImportStep, T> imageCreateImportStep,
                Func<ContainerCreateStep, T> containerCreateStep,
                Func<ContainerStartStep, T> containerStartStep,
                Func<ContainerStopStep, T> containerStopStep,
                Func<ContainerDeleteStep, T> containerDeleteStep,
                Func<ContainerReimageStep, T> containerReimageStep,
                Func<ContainerRestartStep, T> containerRestartStep,
                Func<EnvironmentCreateStep, T> environmentCreateStep,
                Func<EnvironmentStartStep, T> environmentStartStep,
                Func<EnvironmentStopStep, T> environmentStopStep,
                Func<EnvironmentDeleteStep, T> environmentDeleteStep,
                Func<EnvironmentDeploymentStartStep, T> environmentDeploymentStartStep,
                Func<EnvironmentDeploymentStopStep, T> environmentDeploymentStopStep,
                Func<EnvironmentDeploymentsTagStep, T> environmentDeploymentsTagStep,
                Func<EnvironmentDeploymentsPruneStep, T> environmentDeploymentsPruneStep,
                Func<EnvironmentDeploymentHealthyWatchStep, T> environmentDeploymentHealthyWatchStep,
                Func<StackBuildCreateStep, T> stackBuildCreateStep,
                Func<StackBuildGenerateStep, T> stackBuildGenerateStep,
                Func<StackBuildDeployStep, T> stackBuildDeployStep,
                Func<StackPruneStep, T> stackPruneStep,
                Func<WebhookPostStep, T> webhookPostStep,
                Func<WebhookGetStep, T> webhookGetStep,
                Func<SleepStep, T> sleepStep)
            {
                return environmentDeploymentsPruneStep(_value);
            }

            public EnvironmentDeploymentsPruneStepCase Set(EnvironmentDeploymentsPruneStep value)
            {
                _value = value;
                return this;
            }

            public EnvironmentDeploymentsPruneStep Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<EnvironmentDeploymentHealthyWatchStepCase, EnvironmentDeploymentHealthyWatchStep>))]
        private sealed class EnvironmentDeploymentHealthyWatchStepCase : PipelineSteps, ICaseValue<EnvironmentDeploymentHealthyWatchStepCase, EnvironmentDeploymentHealthyWatchStep>
        {
            public EnvironmentDeploymentHealthyWatchStep _value;

            public override T Match<T>(
                Func<ImageSourceCreateStep, T> imageSourceCreateStep,
                Func<ImageCreateStep, T> imageCreateStep,
                Func<ImageImportStep, T> imageImportStep,
                Func<ImagePruneStep, T> imagePruneStep,
                Func<ImageCreateImportStep, T> imageCreateImportStep,
                Func<ContainerCreateStep, T> containerCreateStep,
                Func<ContainerStartStep, T> containerStartStep,
                Func<ContainerStopStep, T> containerStopStep,
                Func<ContainerDeleteStep, T> containerDeleteStep,
                Func<ContainerReimageStep, T> containerReimageStep,
                Func<ContainerRestartStep, T> containerRestartStep,
                Func<EnvironmentCreateStep, T> environmentCreateStep,
                Func<EnvironmentStartStep, T> environmentStartStep,
                Func<EnvironmentStopStep, T> environmentStopStep,
                Func<EnvironmentDeleteStep, T> environmentDeleteStep,
                Func<EnvironmentDeploymentStartStep, T> environmentDeploymentStartStep,
                Func<EnvironmentDeploymentStopStep, T> environmentDeploymentStopStep,
                Func<EnvironmentDeploymentsTagStep, T> environmentDeploymentsTagStep,
                Func<EnvironmentDeploymentsPruneStep, T> environmentDeploymentsPruneStep,
                Func<EnvironmentDeploymentHealthyWatchStep, T> environmentDeploymentHealthyWatchStep,
                Func<StackBuildCreateStep, T> stackBuildCreateStep,
                Func<StackBuildGenerateStep, T> stackBuildGenerateStep,
                Func<StackBuildDeployStep, T> stackBuildDeployStep,
                Func<StackPruneStep, T> stackPruneStep,
                Func<WebhookPostStep, T> webhookPostStep,
                Func<WebhookGetStep, T> webhookGetStep,
                Func<SleepStep, T> sleepStep)
            {
                return environmentDeploymentHealthyWatchStep(_value);
            }

            public EnvironmentDeploymentHealthyWatchStepCase Set(EnvironmentDeploymentHealthyWatchStep value)
            {
                _value = value;
                return this;
            }

            public EnvironmentDeploymentHealthyWatchStep Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<StackBuildCreateStepCase, StackBuildCreateStep>))]
        private sealed class StackBuildCreateStepCase : PipelineSteps, ICaseValue<StackBuildCreateStepCase, StackBuildCreateStep>
        {
            public StackBuildCreateStep _value;

            public override T Match<T>(
                Func<ImageSourceCreateStep, T> imageSourceCreateStep,
                Func<ImageCreateStep, T> imageCreateStep,
                Func<ImageImportStep, T> imageImportStep,
                Func<ImagePruneStep, T> imagePruneStep,
                Func<ImageCreateImportStep, T> imageCreateImportStep,
                Func<ContainerCreateStep, T> containerCreateStep,
                Func<ContainerStartStep, T> containerStartStep,
                Func<ContainerStopStep, T> containerStopStep,
                Func<ContainerDeleteStep, T> containerDeleteStep,
                Func<ContainerReimageStep, T> containerReimageStep,
                Func<ContainerRestartStep, T> containerRestartStep,
                Func<EnvironmentCreateStep, T> environmentCreateStep,
                Func<EnvironmentStartStep, T> environmentStartStep,
                Func<EnvironmentStopStep, T> environmentStopStep,
                Func<EnvironmentDeleteStep, T> environmentDeleteStep,
                Func<EnvironmentDeploymentStartStep, T> environmentDeploymentStartStep,
                Func<EnvironmentDeploymentStopStep, T> environmentDeploymentStopStep,
                Func<EnvironmentDeploymentsTagStep, T> environmentDeploymentsTagStep,
                Func<EnvironmentDeploymentsPruneStep, T> environmentDeploymentsPruneStep,
                Func<EnvironmentDeploymentHealthyWatchStep, T> environmentDeploymentHealthyWatchStep,
                Func<StackBuildCreateStep, T> stackBuildCreateStep,
                Func<StackBuildGenerateStep, T> stackBuildGenerateStep,
                Func<StackBuildDeployStep, T> stackBuildDeployStep,
                Func<StackPruneStep, T> stackPruneStep,
                Func<WebhookPostStep, T> webhookPostStep,
                Func<WebhookGetStep, T> webhookGetStep,
                Func<SleepStep, T> sleepStep)
            {
                return stackBuildCreateStep(_value);
            }

            public StackBuildCreateStepCase Set(StackBuildCreateStep value)
            {
                _value = value;
                return this;
            }

            public StackBuildCreateStep Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<StackBuildGenerateStepCase, StackBuildGenerateStep>))]
        private sealed class StackBuildGenerateStepCase : PipelineSteps, ICaseValue<StackBuildGenerateStepCase, StackBuildGenerateStep>
        {
            public StackBuildGenerateStep _value;

            public override T Match<T>(
                Func<ImageSourceCreateStep, T> imageSourceCreateStep,
                Func<ImageCreateStep, T> imageCreateStep,
                Func<ImageImportStep, T> imageImportStep,
                Func<ImagePruneStep, T> imagePruneStep,
                Func<ImageCreateImportStep, T> imageCreateImportStep,
                Func<ContainerCreateStep, T> containerCreateStep,
                Func<ContainerStartStep, T> containerStartStep,
                Func<ContainerStopStep, T> containerStopStep,
                Func<ContainerDeleteStep, T> containerDeleteStep,
                Func<ContainerReimageStep, T> containerReimageStep,
                Func<ContainerRestartStep, T> containerRestartStep,
                Func<EnvironmentCreateStep, T> environmentCreateStep,
                Func<EnvironmentStartStep, T> environmentStartStep,
                Func<EnvironmentStopStep, T> environmentStopStep,
                Func<EnvironmentDeleteStep, T> environmentDeleteStep,
                Func<EnvironmentDeploymentStartStep, T> environmentDeploymentStartStep,
                Func<EnvironmentDeploymentStopStep, T> environmentDeploymentStopStep,
                Func<EnvironmentDeploymentsTagStep, T> environmentDeploymentsTagStep,
                Func<EnvironmentDeploymentsPruneStep, T> environmentDeploymentsPruneStep,
                Func<EnvironmentDeploymentHealthyWatchStep, T> environmentDeploymentHealthyWatchStep,
                Func<StackBuildCreateStep, T> stackBuildCreateStep,
                Func<StackBuildGenerateStep, T> stackBuildGenerateStep,
                Func<StackBuildDeployStep, T> stackBuildDeployStep,
                Func<StackPruneStep, T> stackPruneStep,
                Func<WebhookPostStep, T> webhookPostStep,
                Func<WebhookGetStep, T> webhookGetStep,
                Func<SleepStep, T> sleepStep)
            {
                return stackBuildGenerateStep(_value);
            }

            public StackBuildGenerateStepCase Set(StackBuildGenerateStep value)
            {
                _value = value;
                return this;
            }

            public StackBuildGenerateStep Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<StackBuildDeployStepCase, StackBuildDeployStep>))]
        private sealed class StackBuildDeployStepCase : PipelineSteps, ICaseValue<StackBuildDeployStepCase, StackBuildDeployStep>
        {
            public StackBuildDeployStep _value;

            public override T Match<T>(
                Func<ImageSourceCreateStep, T> imageSourceCreateStep,
                Func<ImageCreateStep, T> imageCreateStep,
                Func<ImageImportStep, T> imageImportStep,
                Func<ImagePruneStep, T> imagePruneStep,
                Func<ImageCreateImportStep, T> imageCreateImportStep,
                Func<ContainerCreateStep, T> containerCreateStep,
                Func<ContainerStartStep, T> containerStartStep,
                Func<ContainerStopStep, T> containerStopStep,
                Func<ContainerDeleteStep, T> containerDeleteStep,
                Func<ContainerReimageStep, T> containerReimageStep,
                Func<ContainerRestartStep, T> containerRestartStep,
                Func<EnvironmentCreateStep, T> environmentCreateStep,
                Func<EnvironmentStartStep, T> environmentStartStep,
                Func<EnvironmentStopStep, T> environmentStopStep,
                Func<EnvironmentDeleteStep, T> environmentDeleteStep,
                Func<EnvironmentDeploymentStartStep, T> environmentDeploymentStartStep,
                Func<EnvironmentDeploymentStopStep, T> environmentDeploymentStopStep,
                Func<EnvironmentDeploymentsTagStep, T> environmentDeploymentsTagStep,
                Func<EnvironmentDeploymentsPruneStep, T> environmentDeploymentsPruneStep,
                Func<EnvironmentDeploymentHealthyWatchStep, T> environmentDeploymentHealthyWatchStep,
                Func<StackBuildCreateStep, T> stackBuildCreateStep,
                Func<StackBuildGenerateStep, T> stackBuildGenerateStep,
                Func<StackBuildDeployStep, T> stackBuildDeployStep,
                Func<StackPruneStep, T> stackPruneStep,
                Func<WebhookPostStep, T> webhookPostStep,
                Func<WebhookGetStep, T> webhookGetStep,
                Func<SleepStep, T> sleepStep)
            {
                return stackBuildDeployStep(_value);
            }

            public StackBuildDeployStepCase Set(StackBuildDeployStep value)
            {
                _value = value;
                return this;
            }

            public StackBuildDeployStep Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<StackPruneStepCase, StackPruneStep>))]
        private sealed class StackPruneStepCase : PipelineSteps, ICaseValue<StackPruneStepCase, StackPruneStep>
        {
            public StackPruneStep _value;

            public override T Match<T>(
                Func<ImageSourceCreateStep, T> imageSourceCreateStep,
                Func<ImageCreateStep, T> imageCreateStep,
                Func<ImageImportStep, T> imageImportStep,
                Func<ImagePruneStep, T> imagePruneStep,
                Func<ImageCreateImportStep, T> imageCreateImportStep,
                Func<ContainerCreateStep, T> containerCreateStep,
                Func<ContainerStartStep, T> containerStartStep,
                Func<ContainerStopStep, T> containerStopStep,
                Func<ContainerDeleteStep, T> containerDeleteStep,
                Func<ContainerReimageStep, T> containerReimageStep,
                Func<ContainerRestartStep, T> containerRestartStep,
                Func<EnvironmentCreateStep, T> environmentCreateStep,
                Func<EnvironmentStartStep, T> environmentStartStep,
                Func<EnvironmentStopStep, T> environmentStopStep,
                Func<EnvironmentDeleteStep, T> environmentDeleteStep,
                Func<EnvironmentDeploymentStartStep, T> environmentDeploymentStartStep,
                Func<EnvironmentDeploymentStopStep, T> environmentDeploymentStopStep,
                Func<EnvironmentDeploymentsTagStep, T> environmentDeploymentsTagStep,
                Func<EnvironmentDeploymentsPruneStep, T> environmentDeploymentsPruneStep,
                Func<EnvironmentDeploymentHealthyWatchStep, T> environmentDeploymentHealthyWatchStep,
                Func<StackBuildCreateStep, T> stackBuildCreateStep,
                Func<StackBuildGenerateStep, T> stackBuildGenerateStep,
                Func<StackBuildDeployStep, T> stackBuildDeployStep,
                Func<StackPruneStep, T> stackPruneStep,
                Func<WebhookPostStep, T> webhookPostStep,
                Func<WebhookGetStep, T> webhookGetStep,
                Func<SleepStep, T> sleepStep)
            {
                return stackPruneStep(_value);
            }

            public StackPruneStepCase Set(StackPruneStep value)
            {
                _value = value;
                return this;
            }

            public StackPruneStep Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<WebhookPostStepCase, WebhookPostStep>))]
        private sealed class WebhookPostStepCase : PipelineSteps, ICaseValue<WebhookPostStepCase, WebhookPostStep>
        {
            public WebhookPostStep _value;

            public override T Match<T>(
                Func<ImageSourceCreateStep, T> imageSourceCreateStep,
                Func<ImageCreateStep, T> imageCreateStep,
                Func<ImageImportStep, T> imageImportStep,
                Func<ImagePruneStep, T> imagePruneStep,
                Func<ImageCreateImportStep, T> imageCreateImportStep,
                Func<ContainerCreateStep, T> containerCreateStep,
                Func<ContainerStartStep, T> containerStartStep,
                Func<ContainerStopStep, T> containerStopStep,
                Func<ContainerDeleteStep, T> containerDeleteStep,
                Func<ContainerReimageStep, T> containerReimageStep,
                Func<ContainerRestartStep, T> containerRestartStep,
                Func<EnvironmentCreateStep, T> environmentCreateStep,
                Func<EnvironmentStartStep, T> environmentStartStep,
                Func<EnvironmentStopStep, T> environmentStopStep,
                Func<EnvironmentDeleteStep, T> environmentDeleteStep,
                Func<EnvironmentDeploymentStartStep, T> environmentDeploymentStartStep,
                Func<EnvironmentDeploymentStopStep, T> environmentDeploymentStopStep,
                Func<EnvironmentDeploymentsTagStep, T> environmentDeploymentsTagStep,
                Func<EnvironmentDeploymentsPruneStep, T> environmentDeploymentsPruneStep,
                Func<EnvironmentDeploymentHealthyWatchStep, T> environmentDeploymentHealthyWatchStep,
                Func<StackBuildCreateStep, T> stackBuildCreateStep,
                Func<StackBuildGenerateStep, T> stackBuildGenerateStep,
                Func<StackBuildDeployStep, T> stackBuildDeployStep,
                Func<StackPruneStep, T> stackPruneStep,
                Func<WebhookPostStep, T> webhookPostStep,
                Func<WebhookGetStep, T> webhookGetStep,
                Func<SleepStep, T> sleepStep)
            {
                return webhookPostStep(_value);
            }

            public WebhookPostStepCase Set(WebhookPostStep value)
            {
                _value = value;
                return this;
            }

            public WebhookPostStep Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<WebhookGetStepCase, WebhookGetStep>))]
        private sealed class WebhookGetStepCase : PipelineSteps, ICaseValue<WebhookGetStepCase, WebhookGetStep>
        {
            public WebhookGetStep _value;

            public override T Match<T>(
                Func<ImageSourceCreateStep, T> imageSourceCreateStep,
                Func<ImageCreateStep, T> imageCreateStep,
                Func<ImageImportStep, T> imageImportStep,
                Func<ImagePruneStep, T> imagePruneStep,
                Func<ImageCreateImportStep, T> imageCreateImportStep,
                Func<ContainerCreateStep, T> containerCreateStep,
                Func<ContainerStartStep, T> containerStartStep,
                Func<ContainerStopStep, T> containerStopStep,
                Func<ContainerDeleteStep, T> containerDeleteStep,
                Func<ContainerReimageStep, T> containerReimageStep,
                Func<ContainerRestartStep, T> containerRestartStep,
                Func<EnvironmentCreateStep, T> environmentCreateStep,
                Func<EnvironmentStartStep, T> environmentStartStep,
                Func<EnvironmentStopStep, T> environmentStopStep,
                Func<EnvironmentDeleteStep, T> environmentDeleteStep,
                Func<EnvironmentDeploymentStartStep, T> environmentDeploymentStartStep,
                Func<EnvironmentDeploymentStopStep, T> environmentDeploymentStopStep,
                Func<EnvironmentDeploymentsTagStep, T> environmentDeploymentsTagStep,
                Func<EnvironmentDeploymentsPruneStep, T> environmentDeploymentsPruneStep,
                Func<EnvironmentDeploymentHealthyWatchStep, T> environmentDeploymentHealthyWatchStep,
                Func<StackBuildCreateStep, T> stackBuildCreateStep,
                Func<StackBuildGenerateStep, T> stackBuildGenerateStep,
                Func<StackBuildDeployStep, T> stackBuildDeployStep,
                Func<StackPruneStep, T> stackPruneStep,
                Func<WebhookPostStep, T> webhookPostStep,
                Func<WebhookGetStep, T> webhookGetStep,
                Func<SleepStep, T> sleepStep)
            {
                return webhookGetStep(_value);
            }

            public WebhookGetStepCase Set(WebhookGetStep value)
            {
                _value = value;
                return this;
            }

            public WebhookGetStep Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<SleepStepCase, SleepStep>))]
        private sealed class SleepStepCase : PipelineSteps, ICaseValue<SleepStepCase, SleepStep>
        {
            public SleepStep _value;

            public override T Match<T>(
                Func<ImageSourceCreateStep, T> imageSourceCreateStep,
                Func<ImageCreateStep, T> imageCreateStep,
                Func<ImageImportStep, T> imageImportStep,
                Func<ImagePruneStep, T> imagePruneStep,
                Func<ImageCreateImportStep, T> imageCreateImportStep,
                Func<ContainerCreateStep, T> containerCreateStep,
                Func<ContainerStartStep, T> containerStartStep,
                Func<ContainerStopStep, T> containerStopStep,
                Func<ContainerDeleteStep, T> containerDeleteStep,
                Func<ContainerReimageStep, T> containerReimageStep,
                Func<ContainerRestartStep, T> containerRestartStep,
                Func<EnvironmentCreateStep, T> environmentCreateStep,
                Func<EnvironmentStartStep, T> environmentStartStep,
                Func<EnvironmentStopStep, T> environmentStopStep,
                Func<EnvironmentDeleteStep, T> environmentDeleteStep,
                Func<EnvironmentDeploymentStartStep, T> environmentDeploymentStartStep,
                Func<EnvironmentDeploymentStopStep, T> environmentDeploymentStopStep,
                Func<EnvironmentDeploymentsTagStep, T> environmentDeploymentsTagStep,
                Func<EnvironmentDeploymentsPruneStep, T> environmentDeploymentsPruneStep,
                Func<EnvironmentDeploymentHealthyWatchStep, T> environmentDeploymentHealthyWatchStep,
                Func<StackBuildCreateStep, T> stackBuildCreateStep,
                Func<StackBuildGenerateStep, T> stackBuildGenerateStep,
                Func<StackBuildDeployStep, T> stackBuildDeployStep,
                Func<StackPruneStep, T> stackPruneStep,
                Func<WebhookPostStep, T> webhookPostStep,
                Func<WebhookGetStep, T> webhookGetStep,
                Func<SleepStep, T> sleepStep)
            {
                return sleepStep(_value);
            }

            public SleepStepCase Set(SleepStep value)
            {
                _value = value;
                return this;
            }

            public SleepStep Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }
    }
}