// <copyright file="Service2Config.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<Service2Config>),
        new Type[] {
            typeof(Case0)
        },
        false
    )]
    public abstract class Service2Config
    {
        /// <summary>
        /// This is LoadBalancerConfig case.
        /// </summary>
        /// <returns>
        /// The Service2Config instance, wrapping the provided LoadBalancerConfig value.
        /// </returns>
        public static Service2Config FromLoadBalancerConfig(LoadBalancerConfig loadBalancerConfig)
        {
            return new Case0().Set(loadBalancerConfig);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<LoadBalancerConfig, T> loadBalancerConfig);

        [JsonConverter(typeof(UnionTypeCaseConverter<Case0, LoadBalancerConfig>))]
        private sealed class Case0 : Service2Config, ICaseValue<Case0, LoadBalancerConfig>
        {
            public LoadBalancerConfig _value;

            public override T Match<T>(Func<LoadBalancerConfig, T> loadBalancerConfig)
            {
                return loadBalancerConfig(_value);
            }

            public Case0 Set(LoadBalancerConfig value)
            {
                _value = value;
                return this;
            }

            public LoadBalancerConfig Get()
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