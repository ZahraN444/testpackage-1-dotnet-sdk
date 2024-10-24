// <copyright file="StackSpecServicesLoadbalancer.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<StackSpecServicesLoadbalancer>),
        new Type[] {
            typeof(Case0)
        },
        false
    )]
    public abstract class StackSpecServicesLoadbalancer
    {
        /// <summary>
        /// This is StackSpecLoadBalancerConfig case.
        /// </summary>
        /// <returns>
        /// The StackSpecServicesLoadbalancer instance, wrapping the provided StackSpecLoadBalancerConfig value.
        /// </returns>
        public static StackSpecServicesLoadbalancer FromStackSpecLoadBalancerConfig(StackSpecLoadBalancerConfig stackSpecLoadBalancerConfig)
        {
            return new Case0().Set(stackSpecLoadBalancerConfig);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<StackSpecLoadBalancerConfig, T> stackSpecLoadBalancerConfig);

        [JsonConverter(typeof(UnionTypeCaseConverter<Case0, StackSpecLoadBalancerConfig>))]
        private sealed class Case0 : StackSpecServicesLoadbalancer, ICaseValue<Case0, StackSpecLoadBalancerConfig>
        {
            public StackSpecLoadBalancerConfig _value;

            public override T Match<T>(Func<StackSpecLoadBalancerConfig, T> stackSpecLoadBalancerConfig)
            {
                return stackSpecLoadBalancerConfig(_value);
            }

            public Case0 Set(StackSpecLoadBalancerConfig value)
            {
                _value = value;
                return this;
            }

            public StackSpecLoadBalancerConfig Get()
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