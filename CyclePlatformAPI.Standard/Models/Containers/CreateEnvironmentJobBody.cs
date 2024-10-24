// <copyright file="CreateEnvironmentJobBody.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<CreateEnvironmentJobBody>),
        new Type[] {
            typeof(EnvironmentStartActionCase),
            typeof(EnvironmentStopActionCase),
            typeof(EnvironmentInitializeActionCase),
            typeof(EnvironmentReconfigureDeploymentsActionCase)
        },
        true
    )]
    public abstract class CreateEnvironmentJobBody
    {
        /// <summary>
        /// This is EnvironmentStartAction case.
        /// </summary>
        /// <returns>
        /// The CreateEnvironmentJobBody instance, wrapping the provided EnvironmentStartAction value.
        /// </returns>
        public static CreateEnvironmentJobBody FromEnvironmentStartAction(EnvironmentStartAction environmentStartAction)
        {
            return new EnvironmentStartActionCase().Set(environmentStartAction);
        }

        /// <summary>
        /// This is EnvironmentStopAction case.
        /// </summary>
        /// <returns>
        /// The CreateEnvironmentJobBody instance, wrapping the provided EnvironmentStopAction value.
        /// </returns>
        public static CreateEnvironmentJobBody FromEnvironmentStopAction(EnvironmentStopAction environmentStopAction)
        {
            return new EnvironmentStopActionCase().Set(environmentStopAction);
        }

        /// <summary>
        /// This is EnvironmentInitializeAction case.
        /// </summary>
        /// <returns>
        /// The CreateEnvironmentJobBody instance, wrapping the provided EnvironmentInitializeAction value.
        /// </returns>
        public static CreateEnvironmentJobBody FromEnvironmentInitializeAction(EnvironmentInitializeAction environmentInitializeAction)
        {
            return new EnvironmentInitializeActionCase().Set(environmentInitializeAction);
        }

        /// <summary>
        /// This is EnvironmentReconfigureDeploymentsAction case.
        /// </summary>
        /// <returns>
        /// The CreateEnvironmentJobBody instance, wrapping the provided EnvironmentReconfigureDeploymentsAction value.
        /// </returns>
        public static CreateEnvironmentJobBody FromEnvironmentReconfigureDeploymentsAction(EnvironmentReconfigureDeploymentsAction environmentReconfigureDeploymentsAction)
        {
            return new EnvironmentReconfigureDeploymentsActionCase().Set(environmentReconfigureDeploymentsAction);
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
            Func<EnvironmentStartAction, T> environmentStartAction,
            Func<EnvironmentStopAction, T> environmentStopAction,
            Func<EnvironmentInitializeAction, T> environmentInitializeAction,
            Func<EnvironmentReconfigureDeploymentsAction, T> environmentReconfigureDeploymentsAction);

        [JsonConverter(typeof(UnionTypeCaseConverter<EnvironmentStartActionCase, EnvironmentStartAction>))]
        private sealed class EnvironmentStartActionCase : CreateEnvironmentJobBody, ICaseValue<EnvironmentStartActionCase, EnvironmentStartAction>
        {
            public EnvironmentStartAction _value;

            public override T Match<T>(
                Func<EnvironmentStartAction, T> environmentStartAction,
                Func<EnvironmentStopAction, T> environmentStopAction,
                Func<EnvironmentInitializeAction, T> environmentInitializeAction,
                Func<EnvironmentReconfigureDeploymentsAction, T> environmentReconfigureDeploymentsAction)
            {
                return environmentStartAction(_value);
            }

            public EnvironmentStartActionCase Set(EnvironmentStartAction value)
            {
                _value = value;
                return this;
            }

            public EnvironmentStartAction Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<EnvironmentStopActionCase, EnvironmentStopAction>))]
        private sealed class EnvironmentStopActionCase : CreateEnvironmentJobBody, ICaseValue<EnvironmentStopActionCase, EnvironmentStopAction>
        {
            public EnvironmentStopAction _value;

            public override T Match<T>(
                Func<EnvironmentStartAction, T> environmentStartAction,
                Func<EnvironmentStopAction, T> environmentStopAction,
                Func<EnvironmentInitializeAction, T> environmentInitializeAction,
                Func<EnvironmentReconfigureDeploymentsAction, T> environmentReconfigureDeploymentsAction)
            {
                return environmentStopAction(_value);
            }

            public EnvironmentStopActionCase Set(EnvironmentStopAction value)
            {
                _value = value;
                return this;
            }

            public EnvironmentStopAction Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<EnvironmentInitializeActionCase, EnvironmentInitializeAction>))]
        private sealed class EnvironmentInitializeActionCase : CreateEnvironmentJobBody, ICaseValue<EnvironmentInitializeActionCase, EnvironmentInitializeAction>
        {
            public EnvironmentInitializeAction _value;

            public override T Match<T>(
                Func<EnvironmentStartAction, T> environmentStartAction,
                Func<EnvironmentStopAction, T> environmentStopAction,
                Func<EnvironmentInitializeAction, T> environmentInitializeAction,
                Func<EnvironmentReconfigureDeploymentsAction, T> environmentReconfigureDeploymentsAction)
            {
                return environmentInitializeAction(_value);
            }

            public EnvironmentInitializeActionCase Set(EnvironmentInitializeAction value)
            {
                _value = value;
                return this;
            }

            public EnvironmentInitializeAction Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<EnvironmentReconfigureDeploymentsActionCase, EnvironmentReconfigureDeploymentsAction>))]
        private sealed class EnvironmentReconfigureDeploymentsActionCase : CreateEnvironmentJobBody, ICaseValue<EnvironmentReconfigureDeploymentsActionCase, EnvironmentReconfigureDeploymentsAction>
        {
            public EnvironmentReconfigureDeploymentsAction _value;

            public override T Match<T>(
                Func<EnvironmentStartAction, T> environmentStartAction,
                Func<EnvironmentStopAction, T> environmentStopAction,
                Func<EnvironmentInitializeAction, T> environmentInitializeAction,
                Func<EnvironmentReconfigureDeploymentsAction, T> environmentReconfigureDeploymentsAction)
            {
                return environmentReconfigureDeploymentsAction(_value);
            }

            public EnvironmentReconfigureDeploymentsActionCase Set(EnvironmentReconfigureDeploymentsAction value)
            {
                _value = value;
                return this;
            }

            public EnvironmentReconfigureDeploymentsAction Get()
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