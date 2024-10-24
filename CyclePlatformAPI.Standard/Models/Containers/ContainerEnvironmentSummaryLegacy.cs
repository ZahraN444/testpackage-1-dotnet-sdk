// <copyright file="ContainerEnvironmentSummaryLegacy.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<ContainerEnvironmentSummaryLegacy>),
        new Type[] {
            typeof(LegacyNetworkCase)
        },
        false
    )]
    public abstract class ContainerEnvironmentSummaryLegacy
    {
        /// <summary>
        /// This is LegacyNetwork case.
        /// </summary>
        /// <returns>
        /// The ContainerEnvironmentSummaryLegacy instance, wrapping the provided LegacyNetwork value.
        /// </returns>
        public static ContainerEnvironmentSummaryLegacy FromLegacyNetwork(LegacyNetwork legacyNetwork)
        {
            return new LegacyNetworkCase().Set(legacyNetwork);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<LegacyNetwork, T> legacyNetwork);

        [JsonConverter(typeof(UnionTypeCaseConverter<LegacyNetworkCase, LegacyNetwork>))]
        private sealed class LegacyNetworkCase : ContainerEnvironmentSummaryLegacy, ICaseValue<LegacyNetworkCase, LegacyNetwork>
        {
            public LegacyNetwork _value;

            public override T Match<T>(Func<LegacyNetwork, T> legacyNetwork)
            {
                return legacyNetwork(_value);
            }

            public LegacyNetworkCase Set(LegacyNetwork value)
            {
                _value = value;
                return this;
            }

            public LegacyNetwork Get()
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