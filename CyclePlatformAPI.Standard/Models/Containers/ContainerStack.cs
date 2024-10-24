// <copyright file="ContainerStack.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<ContainerStack>),
        new Type[] {
            typeof(ContainerStackSummaryCase)
        },
        false
    )]
    public abstract class ContainerStack
    {
        /// <summary>
        /// This is ContainerStackSummary case.
        /// </summary>
        /// <returns>
        /// The ContainerStack instance, wrapping the provided ContainerStackSummary value.
        /// </returns>
        public static ContainerStack FromContainerStackSummary(ContainerStackSummary containerStackSummary)
        {
            return new ContainerStackSummaryCase().Set(containerStackSummary);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<ContainerStackSummary, T> containerStackSummary);

        [JsonConverter(typeof(UnionTypeCaseConverter<ContainerStackSummaryCase, ContainerStackSummary>))]
        private sealed class ContainerStackSummaryCase : ContainerStack, ICaseValue<ContainerStackSummaryCase, ContainerStackSummary>
        {
            public ContainerStackSummary _value;

            public override T Match<T>(Func<ContainerStackSummary, T> containerStackSummary)
            {
                return containerStackSummary(_value);
            }

            public ContainerStackSummaryCase Set(ContainerStackSummary value)
            {
                _value = value;
                return this;
            }

            public ContainerStackSummary Get()
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