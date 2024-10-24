// <copyright file="StackSpecLoadBalancerConfig.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace CyclePlatformAPI.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<StackSpecLoadBalancerConfig>),
        new Type[] {
            typeof(HaProxyLbTypeCase),
            typeof(V1LbTypeCase),
            typeof(DefaultLbTypeCase)
        },
        new string[] {
            "haproxy",
            "v1",
            "default"
        },
        "type",
        true
    )]
    public abstract class StackSpecLoadBalancerConfig
    {
        /// <summary>
        /// This is HaProxyLbType case.
        /// </summary>
        /// <returns>
        /// The StackSpecLoadBalancerConfig instance, wrapping the provided HaProxyLbType value.
        /// </returns>
        public static StackSpecLoadBalancerConfig FromHaProxyLbType(HaProxyLbType haProxyLbType)
        {
            return new HaProxyLbTypeCase().Set(haProxyLbType);
        }

        /// <summary>
        /// This is V1LbType case.
        /// </summary>
        /// <returns>
        /// The StackSpecLoadBalancerConfig instance, wrapping the provided V1LbType value.
        /// </returns>
        public static StackSpecLoadBalancerConfig FromV1LbType(V1LbType v1LbType)
        {
            return new V1LbTypeCase().Set(v1LbType);
        }

        /// <summary>
        /// This is DefaultLbType case.
        /// </summary>
        /// <returns>
        /// The StackSpecLoadBalancerConfig instance, wrapping the provided DefaultLbType value.
        /// </returns>
        public static StackSpecLoadBalancerConfig FromDefaultLbType(DefaultLbType defaultLbType)
        {
            return new DefaultLbTypeCase().Set(defaultLbType);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(
            Func<HaProxyLbType, T> haProxyLbType,
            Func<V1LbType, T> v1LbType,
            Func<DefaultLbType, T> defaultLbType);

        [JsonConverter(typeof(UnionTypeCaseConverter<HaProxyLbTypeCase, HaProxyLbType>))]
        private sealed class HaProxyLbTypeCase : StackSpecLoadBalancerConfig, ICaseValue<HaProxyLbTypeCase, HaProxyLbType>
        {
            public HaProxyLbType _value;

            public override T Match<T>(
                Func<HaProxyLbType, T> haProxyLbType,
                Func<V1LbType, T> v1LbType,
                Func<DefaultLbType, T> defaultLbType)
            {
                return haProxyLbType(_value);
            }

            public HaProxyLbTypeCase Set(HaProxyLbType value)
            {
                _value = value;
                return this;
            }

            public HaProxyLbType Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<V1LbTypeCase, V1LbType>))]
        private sealed class V1LbTypeCase : StackSpecLoadBalancerConfig, ICaseValue<V1LbTypeCase, V1LbType>
        {
            public V1LbType _value;

            public override T Match<T>(
                Func<HaProxyLbType, T> haProxyLbType,
                Func<V1LbType, T> v1LbType,
                Func<DefaultLbType, T> defaultLbType)
            {
                return v1LbType(_value);
            }

            public V1LbTypeCase Set(V1LbType value)
            {
                _value = value;
                return this;
            }

            public V1LbType Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<DefaultLbTypeCase, DefaultLbType>))]
        private sealed class DefaultLbTypeCase : StackSpecLoadBalancerConfig, ICaseValue<DefaultLbTypeCase, DefaultLbType>
        {
            public DefaultLbType _value;

            public override T Match<T>(
                Func<HaProxyLbType, T> haProxyLbType,
                Func<V1LbType, T> v1LbType,
                Func<DefaultLbType, T> defaultLbType)
            {
                return defaultLbType(_value);
            }

            public DefaultLbTypeCase Set(DefaultLbType value)
            {
                _value = value;
                return this;
            }

            public DefaultLbType Get()
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