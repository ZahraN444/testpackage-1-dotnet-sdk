// <copyright file="CreateServerJobBody.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<CreateServerJobBody>),
        new Type[] {
            typeof(ReconfigureSharedFsCase),
            typeof(ReconfigureServerActionCase),
            typeof(RestartServerActionCase),
            typeof(RestartComputeServiceActionCase),
            typeof(RestartComputeSpawnerCase)
        },
        true
    )]
    public abstract class CreateServerJobBody
    {
        /// <summary>
        /// This is ReconfigureSharedFs case.
        /// </summary>
        /// <returns>
        /// The CreateServerJobBody instance, wrapping the provided ReconfigureSharedFs value.
        /// </returns>
        public static CreateServerJobBody FromReconfigureSharedFs(ReconfigureSharedFs reconfigureSharedFs)
        {
            return new ReconfigureSharedFsCase().Set(reconfigureSharedFs);
        }

        /// <summary>
        /// This is ReconfigureServerAction case.
        /// </summary>
        /// <returns>
        /// The CreateServerJobBody instance, wrapping the provided ReconfigureServerAction value.
        /// </returns>
        public static CreateServerJobBody FromReconfigureServerAction(ReconfigureServerAction reconfigureServerAction)
        {
            return new ReconfigureServerActionCase().Set(reconfigureServerAction);
        }

        /// <summary>
        /// This is RestartServerAction case.
        /// </summary>
        /// <returns>
        /// The CreateServerJobBody instance, wrapping the provided RestartServerAction value.
        /// </returns>
        public static CreateServerJobBody FromRestartServerAction(RestartServerAction restartServerAction)
        {
            return new RestartServerActionCase().Set(restartServerAction);
        }

        /// <summary>
        /// This is RestartComputeServiceAction case.
        /// </summary>
        /// <returns>
        /// The CreateServerJobBody instance, wrapping the provided RestartComputeServiceAction value.
        /// </returns>
        public static CreateServerJobBody FromRestartComputeServiceAction(RestartComputeServiceAction restartComputeServiceAction)
        {
            return new RestartComputeServiceActionCase().Set(restartComputeServiceAction);
        }

        /// <summary>
        /// This is RestartComputeSpawner case.
        /// </summary>
        /// <returns>
        /// The CreateServerJobBody instance, wrapping the provided RestartComputeSpawner value.
        /// </returns>
        public static CreateServerJobBody FromRestartComputeSpawner(RestartComputeSpawner restartComputeSpawner)
        {
            return new RestartComputeSpawnerCase().Set(restartComputeSpawner);
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
            Func<ReconfigureSharedFs, T> reconfigureSharedFs,
            Func<ReconfigureServerAction, T> reconfigureServerAction,
            Func<RestartServerAction, T> restartServerAction,
            Func<RestartComputeServiceAction, T> restartComputeServiceAction,
            Func<RestartComputeSpawner, T> restartComputeSpawner);

        [JsonConverter(typeof(UnionTypeCaseConverter<ReconfigureSharedFsCase, ReconfigureSharedFs>))]
        private sealed class ReconfigureSharedFsCase : CreateServerJobBody, ICaseValue<ReconfigureSharedFsCase, ReconfigureSharedFs>
        {
            public ReconfigureSharedFs _value;

            public override T Match<T>(
                Func<ReconfigureSharedFs, T> reconfigureSharedFs,
                Func<ReconfigureServerAction, T> reconfigureServerAction,
                Func<RestartServerAction, T> restartServerAction,
                Func<RestartComputeServiceAction, T> restartComputeServiceAction,
                Func<RestartComputeSpawner, T> restartComputeSpawner)
            {
                return reconfigureSharedFs(_value);
            }

            public ReconfigureSharedFsCase Set(ReconfigureSharedFs value)
            {
                _value = value;
                return this;
            }

            public ReconfigureSharedFs Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ReconfigureServerActionCase, ReconfigureServerAction>))]
        private sealed class ReconfigureServerActionCase : CreateServerJobBody, ICaseValue<ReconfigureServerActionCase, ReconfigureServerAction>
        {
            public ReconfigureServerAction _value;

            public override T Match<T>(
                Func<ReconfigureSharedFs, T> reconfigureSharedFs,
                Func<ReconfigureServerAction, T> reconfigureServerAction,
                Func<RestartServerAction, T> restartServerAction,
                Func<RestartComputeServiceAction, T> restartComputeServiceAction,
                Func<RestartComputeSpawner, T> restartComputeSpawner)
            {
                return reconfigureServerAction(_value);
            }

            public ReconfigureServerActionCase Set(ReconfigureServerAction value)
            {
                _value = value;
                return this;
            }

            public ReconfigureServerAction Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<RestartServerActionCase, RestartServerAction>))]
        private sealed class RestartServerActionCase : CreateServerJobBody, ICaseValue<RestartServerActionCase, RestartServerAction>
        {
            public RestartServerAction _value;

            public override T Match<T>(
                Func<ReconfigureSharedFs, T> reconfigureSharedFs,
                Func<ReconfigureServerAction, T> reconfigureServerAction,
                Func<RestartServerAction, T> restartServerAction,
                Func<RestartComputeServiceAction, T> restartComputeServiceAction,
                Func<RestartComputeSpawner, T> restartComputeSpawner)
            {
                return restartServerAction(_value);
            }

            public RestartServerActionCase Set(RestartServerAction value)
            {
                _value = value;
                return this;
            }

            public RestartServerAction Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<RestartComputeServiceActionCase, RestartComputeServiceAction>))]
        private sealed class RestartComputeServiceActionCase : CreateServerJobBody, ICaseValue<RestartComputeServiceActionCase, RestartComputeServiceAction>
        {
            public RestartComputeServiceAction _value;

            public override T Match<T>(
                Func<ReconfigureSharedFs, T> reconfigureSharedFs,
                Func<ReconfigureServerAction, T> reconfigureServerAction,
                Func<RestartServerAction, T> restartServerAction,
                Func<RestartComputeServiceAction, T> restartComputeServiceAction,
                Func<RestartComputeSpawner, T> restartComputeSpawner)
            {
                return restartComputeServiceAction(_value);
            }

            public RestartComputeServiceActionCase Set(RestartComputeServiceAction value)
            {
                _value = value;
                return this;
            }

            public RestartComputeServiceAction Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<RestartComputeSpawnerCase, RestartComputeSpawner>))]
        private sealed class RestartComputeSpawnerCase : CreateServerJobBody, ICaseValue<RestartComputeSpawnerCase, RestartComputeSpawner>
        {
            public RestartComputeSpawner _value;

            public override T Match<T>(
                Func<ReconfigureSharedFs, T> reconfigureSharedFs,
                Func<ReconfigureServerAction, T> reconfigureServerAction,
                Func<RestartServerAction, T> restartServerAction,
                Func<RestartComputeServiceAction, T> restartComputeServiceAction,
                Func<RestartComputeSpawner, T> restartComputeSpawner)
            {
                return restartComputeSpawner(_value);
            }

            public RestartComputeSpawnerCase Set(RestartComputeSpawner value)
            {
                _value = value;
                return this;
            }

            public RestartComputeSpawner Get()
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