// <copyright file="EnvironmentServiceSummaryVpn.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<EnvironmentServiceSummaryVpn>),
        new Type[] {
            typeof(EnvironmentServiceContainerSummaryCase)
        },
        false
    )]
    public abstract class EnvironmentServiceSummaryVpn
    {
        /// <summary>
        /// This is EnvironmentServiceContainerSummary case.
        /// </summary>
        /// <returns>
        /// The EnvironmentServiceSummaryVpn instance, wrapping the provided EnvironmentServiceContainerSummary value.
        /// </returns>
        public static EnvironmentServiceSummaryVpn FromEnvironmentServiceContainerSummary(EnvironmentServiceContainerSummary environmentServiceContainerSummary)
        {
            return new EnvironmentServiceContainerSummaryCase().Set(environmentServiceContainerSummary);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<EnvironmentServiceContainerSummary, T> environmentServiceContainerSummary);

        [JsonConverter(typeof(UnionTypeCaseConverter<EnvironmentServiceContainerSummaryCase, EnvironmentServiceContainerSummary>))]
        private sealed class EnvironmentServiceContainerSummaryCase : EnvironmentServiceSummaryVpn, ICaseValue<EnvironmentServiceContainerSummaryCase, EnvironmentServiceContainerSummary>
        {
            public EnvironmentServiceContainerSummary _value;

            public override T Match<T>(Func<EnvironmentServiceContainerSummary, T> environmentServiceContainerSummary)
            {
                return environmentServiceContainerSummary(_value);
            }

            public EnvironmentServiceContainerSummaryCase Set(EnvironmentServiceContainerSummary value)
            {
                _value = value;
                return this;
            }

            public EnvironmentServiceContainerSummary Get()
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