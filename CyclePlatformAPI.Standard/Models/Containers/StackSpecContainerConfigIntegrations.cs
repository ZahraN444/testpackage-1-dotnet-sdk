// <copyright file="StackSpecContainerConfigIntegrations.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace CyclePlatformAPI.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for any-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<StackSpecContainerConfigIntegrations>),
        new Type[] {
            typeof(StackContainerConfigIntegrationsCase)
        },
        false
    )]
    public abstract class StackSpecContainerConfigIntegrations
    {
        /// <summary>
        /// This is StackContainerConfigIntegrations case.
        /// </summary>
        /// <returns>
        /// The StackSpecContainerConfigIntegrations instance, wrapping the provided StackContainerConfigIntegrations value.
        /// </returns>
        public static StackSpecContainerConfigIntegrations FromStackContainerConfigIntegrations(StackContainerConfigIntegrations stackContainerConfigIntegrations)
        {
            return new StackContainerConfigIntegrationsCase().Set(stackContainerConfigIntegrations);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<StackContainerConfigIntegrations, T> stackContainerConfigIntegrations);

        [JsonConverter(typeof(UnionTypeCaseConverter<StackContainerConfigIntegrationsCase, StackContainerConfigIntegrations>))]
        private sealed class StackContainerConfigIntegrationsCase : StackSpecContainerConfigIntegrations, ICaseValue<StackContainerConfigIntegrationsCase, StackContainerConfigIntegrations>
        {
            public StackContainerConfigIntegrations _value;

            public override T Match<T>(Func<StackContainerConfigIntegrations, T> stackContainerConfigIntegrations)
            {
                return stackContainerConfigIntegrations(_value);
            }

            public StackContainerConfigIntegrationsCase Set(StackContainerConfigIntegrations value)
            {
                _value = value;
                return this;
            }

            public StackContainerConfigIntegrations Get()
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