// <copyright file="LoadBalancerTelemetrySnapshotRouter.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<LoadBalancerTelemetrySnapshotRouter>),
        new Type[] {
            typeof(LoadBalancerTelemetryRouterMetricsCase)
        },
        false
    )]
    public abstract class LoadBalancerTelemetrySnapshotRouter
    {
        /// <summary>
        /// This is LoadBalancerTelemetryRouterMetrics case.
        /// </summary>
        /// <returns>
        /// The LoadBalancerTelemetrySnapshotRouter instance, wrapping the provided LoadBalancerTelemetryRouterMetrics value.
        /// </returns>
        public static LoadBalancerTelemetrySnapshotRouter FromLoadBalancerTelemetryRouterMetrics(LoadBalancerTelemetryRouterMetrics loadBalancerTelemetryRouterMetrics)
        {
            return new LoadBalancerTelemetryRouterMetricsCase().Set(loadBalancerTelemetryRouterMetrics);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<LoadBalancerTelemetryRouterMetrics, T> loadBalancerTelemetryRouterMetrics);

        [JsonConverter(typeof(UnionTypeCaseConverter<LoadBalancerTelemetryRouterMetricsCase, LoadBalancerTelemetryRouterMetrics>))]
        private sealed class LoadBalancerTelemetryRouterMetricsCase : LoadBalancerTelemetrySnapshotRouter, ICaseValue<LoadBalancerTelemetryRouterMetricsCase, LoadBalancerTelemetryRouterMetrics>
        {
            public LoadBalancerTelemetryRouterMetrics _value;

            public override T Match<T>(Func<LoadBalancerTelemetryRouterMetrics, T> loadBalancerTelemetryRouterMetrics)
            {
                return loadBalancerTelemetryRouterMetrics(_value);
            }

            public LoadBalancerTelemetryRouterMetricsCase Set(LoadBalancerTelemetryRouterMetrics value)
            {
                _value = value;
                return this;
            }

            public LoadBalancerTelemetryRouterMetrics Get()
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