// <copyright file="DiscoveryConfig2.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<DiscoveryConfig2>),
        new Type[] {
            typeof(DiscoveryConfigCase)
        },
        false
    )]
    public abstract class DiscoveryConfig2
    {
        /// <summary>
        /// This is DiscoveryConfig case.
        /// </summary>
        /// <returns>
        /// The DiscoveryConfig2 instance, wrapping the provided DiscoveryConfig value.
        /// </returns>
        public static DiscoveryConfig2 FromDiscoveryConfig(DiscoveryConfig discoveryConfig)
        {
            return new DiscoveryConfigCase().Set(discoveryConfig);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<DiscoveryConfig, T> discoveryConfig);

        [JsonConverter(typeof(UnionTypeCaseConverter<DiscoveryConfigCase, DiscoveryConfig>))]
        private sealed class DiscoveryConfigCase : DiscoveryConfig2, ICaseValue<DiscoveryConfigCase, DiscoveryConfig>
        {
            public DiscoveryConfig _value;

            public override T Match<T>(Func<DiscoveryConfig, T> discoveryConfig)
            {
                return discoveryConfig(_value);
            }

            public DiscoveryConfigCase Set(DiscoveryConfig value)
            {
                _value = value;
                return this;
            }

            public DiscoveryConfig Get()
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