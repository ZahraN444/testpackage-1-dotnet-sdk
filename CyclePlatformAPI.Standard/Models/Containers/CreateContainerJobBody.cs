// <copyright file="CreateContainerJobBody.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<CreateContainerJobBody>),
        new Type[] {
            typeof(ContainerStartActionTaskCase),
            typeof(ContainerStopActionTaskCase),
            typeof(ReconfigureContainerCase),
            typeof(ReconfigureVolumeTaskCase),
            typeof(ReimageContainerCase),
            typeof(ScaleContainerCase)
        },
        true
    )]
    public abstract class CreateContainerJobBody
    {
        /// <summary>
        /// This is ContainerStartActionTask case.
        /// </summary>
        /// <returns>
        /// The CreateContainerJobBody instance, wrapping the provided ContainerStartActionTask value.
        /// </returns>
        public static CreateContainerJobBody FromContainerStartActionTask(ContainerStartActionTask containerStartActionTask)
        {
            return new ContainerStartActionTaskCase().Set(containerStartActionTask);
        }

        /// <summary>
        /// This is ContainerStopActionTask case.
        /// </summary>
        /// <returns>
        /// The CreateContainerJobBody instance, wrapping the provided ContainerStopActionTask value.
        /// </returns>
        public static CreateContainerJobBody FromContainerStopActionTask(ContainerStopActionTask containerStopActionTask)
        {
            return new ContainerStopActionTaskCase().Set(containerStopActionTask);
        }

        /// <summary>
        /// This is ReconfigureContainer case.
        /// </summary>
        /// <returns>
        /// The CreateContainerJobBody instance, wrapping the provided ReconfigureContainer value.
        /// </returns>
        public static CreateContainerJobBody FromReconfigureContainer(ReconfigureContainer reconfigureContainer)
        {
            return new ReconfigureContainerCase().Set(reconfigureContainer);
        }

        /// <summary>
        /// This is ReconfigureVolumeTask case.
        /// </summary>
        /// <returns>
        /// The CreateContainerJobBody instance, wrapping the provided ReconfigureVolumeTask value.
        /// </returns>
        public static CreateContainerJobBody FromReconfigureVolumeTask(ReconfigureVolumeTask reconfigureVolumeTask)
        {
            return new ReconfigureVolumeTaskCase().Set(reconfigureVolumeTask);
        }

        /// <summary>
        /// This is ReimageContainer case.
        /// </summary>
        /// <returns>
        /// The CreateContainerJobBody instance, wrapping the provided ReimageContainer value.
        /// </returns>
        public static CreateContainerJobBody FromReimageContainer(ReimageContainer reimageContainer)
        {
            return new ReimageContainerCase().Set(reimageContainer);
        }

        /// <summary>
        /// This is ScaleContainer case.
        /// </summary>
        /// <returns>
        /// The CreateContainerJobBody instance, wrapping the provided ScaleContainer value.
        /// </returns>
        public static CreateContainerJobBody FromScaleContainer(ScaleContainer scaleContainer)
        {
            return new ScaleContainerCase().Set(scaleContainer);
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
            Func<ContainerStartActionTask, T> containerStartActionTask,
            Func<ContainerStopActionTask, T> containerStopActionTask,
            Func<ReconfigureContainer, T> reconfigureContainer,
            Func<ReconfigureVolumeTask, T> reconfigureVolumeTask,
            Func<ReimageContainer, T> reimageContainer,
            Func<ScaleContainer, T> scaleContainer);

        [JsonConverter(typeof(UnionTypeCaseConverter<ContainerStartActionTaskCase, ContainerStartActionTask>))]
        private sealed class ContainerStartActionTaskCase : CreateContainerJobBody, ICaseValue<ContainerStartActionTaskCase, ContainerStartActionTask>
        {
            public ContainerStartActionTask _value;

            public override T Match<T>(
                Func<ContainerStartActionTask, T> containerStartActionTask,
                Func<ContainerStopActionTask, T> containerStopActionTask,
                Func<ReconfigureContainer, T> reconfigureContainer,
                Func<ReconfigureVolumeTask, T> reconfigureVolumeTask,
                Func<ReimageContainer, T> reimageContainer,
                Func<ScaleContainer, T> scaleContainer)
            {
                return containerStartActionTask(_value);
            }

            public ContainerStartActionTaskCase Set(ContainerStartActionTask value)
            {
                _value = value;
                return this;
            }

            public ContainerStartActionTask Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ContainerStopActionTaskCase, ContainerStopActionTask>))]
        private sealed class ContainerStopActionTaskCase : CreateContainerJobBody, ICaseValue<ContainerStopActionTaskCase, ContainerStopActionTask>
        {
            public ContainerStopActionTask _value;

            public override T Match<T>(
                Func<ContainerStartActionTask, T> containerStartActionTask,
                Func<ContainerStopActionTask, T> containerStopActionTask,
                Func<ReconfigureContainer, T> reconfigureContainer,
                Func<ReconfigureVolumeTask, T> reconfigureVolumeTask,
                Func<ReimageContainer, T> reimageContainer,
                Func<ScaleContainer, T> scaleContainer)
            {
                return containerStopActionTask(_value);
            }

            public ContainerStopActionTaskCase Set(ContainerStopActionTask value)
            {
                _value = value;
                return this;
            }

            public ContainerStopActionTask Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ReconfigureContainerCase, ReconfigureContainer>))]
        private sealed class ReconfigureContainerCase : CreateContainerJobBody, ICaseValue<ReconfigureContainerCase, ReconfigureContainer>
        {
            public ReconfigureContainer _value;

            public override T Match<T>(
                Func<ContainerStartActionTask, T> containerStartActionTask,
                Func<ContainerStopActionTask, T> containerStopActionTask,
                Func<ReconfigureContainer, T> reconfigureContainer,
                Func<ReconfigureVolumeTask, T> reconfigureVolumeTask,
                Func<ReimageContainer, T> reimageContainer,
                Func<ScaleContainer, T> scaleContainer)
            {
                return reconfigureContainer(_value);
            }

            public ReconfigureContainerCase Set(ReconfigureContainer value)
            {
                _value = value;
                return this;
            }

            public ReconfigureContainer Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ReconfigureVolumeTaskCase, ReconfigureVolumeTask>))]
        private sealed class ReconfigureVolumeTaskCase : CreateContainerJobBody, ICaseValue<ReconfigureVolumeTaskCase, ReconfigureVolumeTask>
        {
            public ReconfigureVolumeTask _value;

            public override T Match<T>(
                Func<ContainerStartActionTask, T> containerStartActionTask,
                Func<ContainerStopActionTask, T> containerStopActionTask,
                Func<ReconfigureContainer, T> reconfigureContainer,
                Func<ReconfigureVolumeTask, T> reconfigureVolumeTask,
                Func<ReimageContainer, T> reimageContainer,
                Func<ScaleContainer, T> scaleContainer)
            {
                return reconfigureVolumeTask(_value);
            }

            public ReconfigureVolumeTaskCase Set(ReconfigureVolumeTask value)
            {
                _value = value;
                return this;
            }

            public ReconfigureVolumeTask Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ReimageContainerCase, ReimageContainer>))]
        private sealed class ReimageContainerCase : CreateContainerJobBody, ICaseValue<ReimageContainerCase, ReimageContainer>
        {
            public ReimageContainer _value;

            public override T Match<T>(
                Func<ContainerStartActionTask, T> containerStartActionTask,
                Func<ContainerStopActionTask, T> containerStopActionTask,
                Func<ReconfigureContainer, T> reconfigureContainer,
                Func<ReconfigureVolumeTask, T> reconfigureVolumeTask,
                Func<ReimageContainer, T> reimageContainer,
                Func<ScaleContainer, T> scaleContainer)
            {
                return reimageContainer(_value);
            }

            public ReimageContainerCase Set(ReimageContainer value)
            {
                _value = value;
                return this;
            }

            public ReimageContainer Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ScaleContainerCase, ScaleContainer>))]
        private sealed class ScaleContainerCase : CreateContainerJobBody, ICaseValue<ScaleContainerCase, ScaleContainer>
        {
            public ScaleContainer _value;

            public override T Match<T>(
                Func<ContainerStartActionTask, T> containerStartActionTask,
                Func<ContainerStopActionTask, T> containerStopActionTask,
                Func<ReconfigureContainer, T> reconfigureContainer,
                Func<ReconfigureVolumeTask, T> reconfigureVolumeTask,
                Func<ReimageContainer, T> reimageContainer,
                Func<ScaleContainer, T> scaleContainer)
            {
                return scaleContainer(_value);
            }

            public ScaleContainerCase Set(ScaleContainer value)
            {
                _value = value;
                return this;
            }

            public ScaleContainer Get()
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