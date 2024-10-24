// <copyright file="EnvironmentServicesDiscovery.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<EnvironmentServicesDiscovery>),
        new Type[] {
            typeof(DiscoveryEnvironmentServiceCase)
        },
        false
    )]
    public abstract class EnvironmentServicesDiscovery
    {
        /// <summary>
        /// This is DiscoveryEnvironmentService case.
        /// </summary>
        /// <returns>
        /// The EnvironmentServicesDiscovery instance, wrapping the provided DiscoveryEnvironmentService value.
        /// </returns>
        public static EnvironmentServicesDiscovery FromDiscoveryEnvironmentService(DiscoveryEnvironmentService discoveryEnvironmentService)
        {
            return new DiscoveryEnvironmentServiceCase().Set(discoveryEnvironmentService);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<DiscoveryEnvironmentService, T> discoveryEnvironmentService);

        [JsonConverter(typeof(UnionTypeCaseConverter<DiscoveryEnvironmentServiceCase, DiscoveryEnvironmentService>))]
        private sealed class DiscoveryEnvironmentServiceCase : EnvironmentServicesDiscovery, ICaseValue<DiscoveryEnvironmentServiceCase, DiscoveryEnvironmentService>
        {
            public DiscoveryEnvironmentService _value;

            public override T Match<T>(Func<DiscoveryEnvironmentService, T> discoveryEnvironmentService)
            {
                return discoveryEnvironmentService(_value);
            }

            public DiscoveryEnvironmentServiceCase Set(DiscoveryEnvironmentService value)
            {
                _value = value;
                return this;
            }

            public DiscoveryEnvironmentService Get()
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