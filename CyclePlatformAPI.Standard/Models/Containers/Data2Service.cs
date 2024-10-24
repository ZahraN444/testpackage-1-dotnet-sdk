// <copyright file="Data2Service.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<Data2Service>),
        new Type[] {
            typeof(LoadBalancerEnvironmentServiceCase)
        },
        false
    )]
    public abstract class Data2Service
    {
        /// <summary>
        /// This is LoadBalancerEnvironmentService case.
        /// </summary>
        /// <returns>
        /// The Data2Service instance, wrapping the provided LoadBalancerEnvironmentService value.
        /// </returns>
        public static Data2Service FromLoadBalancerEnvironmentService(LoadBalancerEnvironmentService loadBalancerEnvironmentService)
        {
            return new LoadBalancerEnvironmentServiceCase().Set(loadBalancerEnvironmentService);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<LoadBalancerEnvironmentService, T> loadBalancerEnvironmentService);

        [JsonConverter(typeof(UnionTypeCaseConverter<LoadBalancerEnvironmentServiceCase, LoadBalancerEnvironmentService>))]
        private sealed class LoadBalancerEnvironmentServiceCase : Data2Service, ICaseValue<LoadBalancerEnvironmentServiceCase, LoadBalancerEnvironmentService>
        {
            public LoadBalancerEnvironmentService _value;

            public override T Match<T>(Func<LoadBalancerEnvironmentService, T> loadBalancerEnvironmentService)
            {
                return loadBalancerEnvironmentService(_value);
            }

            public LoadBalancerEnvironmentServiceCase Set(LoadBalancerEnvironmentService value)
            {
                _value = value;
                return this;
            }

            public LoadBalancerEnvironmentService Get()
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