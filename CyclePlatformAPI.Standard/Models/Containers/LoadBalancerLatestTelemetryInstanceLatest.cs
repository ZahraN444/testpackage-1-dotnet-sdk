// <copyright file="LoadBalancerLatestTelemetryInstanceLatest.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<LoadBalancerLatestTelemetryInstanceLatest>),
        new Type[] {
            typeof(LoadBalancerTelemetrySnapshotCase)
        },
        false
    )]
    public abstract class LoadBalancerLatestTelemetryInstanceLatest
    {
        /// <summary>
        /// This is LoadBalancerTelemetrySnapshot case.
        /// </summary>
        /// <returns>
        /// The LoadBalancerLatestTelemetryInstanceLatest instance, wrapping the provided LoadBalancerTelemetrySnapshot value.
        /// </returns>
        public static LoadBalancerLatestTelemetryInstanceLatest FromLoadBalancerTelemetrySnapshot(LoadBalancerTelemetrySnapshot loadBalancerTelemetrySnapshot)
        {
            return new LoadBalancerTelemetrySnapshotCase().Set(loadBalancerTelemetrySnapshot);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<LoadBalancerTelemetrySnapshot, T> loadBalancerTelemetrySnapshot);

        [JsonConverter(typeof(UnionTypeCaseConverter<LoadBalancerTelemetrySnapshotCase, LoadBalancerTelemetrySnapshot>))]
        private sealed class LoadBalancerTelemetrySnapshotCase : LoadBalancerLatestTelemetryInstanceLatest, ICaseValue<LoadBalancerTelemetrySnapshotCase, LoadBalancerTelemetrySnapshot>
        {
            public LoadBalancerTelemetrySnapshot _value;

            public override T Match<T>(Func<LoadBalancerTelemetrySnapshot, T> loadBalancerTelemetrySnapshot)
            {
                return loadBalancerTelemetrySnapshot(_value);
            }

            public LoadBalancerTelemetrySnapshotCase Set(LoadBalancerTelemetrySnapshot value)
            {
                _value = value;
                return this;
            }

            public LoadBalancerTelemetrySnapshot Get()
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