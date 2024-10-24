// <copyright file="LoadBalancerTelemetrySnapshotUrls.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<LoadBalancerTelemetrySnapshotUrls>),
        new Type[] {
            typeof(LoadBalancerTelemetryUrlMetricsCase)
        },
        false
    )]
    public abstract class LoadBalancerTelemetrySnapshotUrls
    {
        /// <summary>
        /// This is LoadBalancerTelemetryUrlMetrics case.
        /// </summary>
        /// <returns>
        /// The LoadBalancerTelemetrySnapshotUrls instance, wrapping the provided LoadBalancerTelemetryUrlMetrics value.
        /// </returns>
        public static LoadBalancerTelemetrySnapshotUrls FromLoadBalancerTelemetryUrlMetrics(LoadBalancerTelemetryUrlMetrics loadBalancerTelemetryUrlMetrics)
        {
            return new LoadBalancerTelemetryUrlMetricsCase().Set(loadBalancerTelemetryUrlMetrics);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<LoadBalancerTelemetryUrlMetrics, T> loadBalancerTelemetryUrlMetrics);

        [JsonConverter(typeof(UnionTypeCaseConverter<LoadBalancerTelemetryUrlMetricsCase, LoadBalancerTelemetryUrlMetrics>))]
        private sealed class LoadBalancerTelemetryUrlMetricsCase : LoadBalancerTelemetrySnapshotUrls, ICaseValue<LoadBalancerTelemetryUrlMetricsCase, LoadBalancerTelemetryUrlMetrics>
        {
            public LoadBalancerTelemetryUrlMetrics _value;

            public override T Match<T>(Func<LoadBalancerTelemetryUrlMetrics, T> loadBalancerTelemetryUrlMetrics)
            {
                return loadBalancerTelemetryUrlMetrics(_value);
            }

            public LoadBalancerTelemetryUrlMetricsCase Set(LoadBalancerTelemetryUrlMetrics value)
            {
                _value = value;
                return this;
            }

            public LoadBalancerTelemetryUrlMetrics Get()
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