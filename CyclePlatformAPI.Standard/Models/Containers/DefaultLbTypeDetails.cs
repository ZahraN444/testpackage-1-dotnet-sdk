// <copyright file="DefaultLbTypeDetails.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<DefaultLbTypeDetails>),
        new Type[] {
            typeof(HaProxyConfig1Case),
            typeof(V1LbConfigCase)
        },
        true
    )]
    public abstract class DefaultLbTypeDetails
    {
        /// <summary>
        /// This is HaProxyConfig1 case.
        /// </summary>
        /// <returns>
        /// The DefaultLbTypeDetails instance, wrapping the provided HaProxyConfig1 value.
        /// </returns>
        public static DefaultLbTypeDetails FromHaProxyConfig1(HaProxyConfig1 haProxyConfig1)
        {
            return new HaProxyConfig1Case().Set(haProxyConfig1);
        }

        /// <summary>
        /// This is V1LbConfig case.
        /// </summary>
        /// <returns>
        /// The DefaultLbTypeDetails instance, wrapping the provided V1LbConfig value.
        /// </returns>
        public static DefaultLbTypeDetails FromV1LbConfig(V1LbConfig v1LbConfig)
        {
            return new V1LbConfigCase().Set(v1LbConfig);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<HaProxyConfig1, T> haProxyConfig1, Func<V1LbConfig, T> v1LbConfig);

        [JsonConverter(typeof(UnionTypeCaseConverter<HaProxyConfig1Case, HaProxyConfig1>))]
        private sealed class HaProxyConfig1Case : DefaultLbTypeDetails, ICaseValue<HaProxyConfig1Case, HaProxyConfig1>
        {
            public HaProxyConfig1 _value;

            public override T Match<T>(Func<HaProxyConfig1, T> haProxyConfig1, Func<V1LbConfig, T> v1LbConfig)
            {
                return haProxyConfig1(_value);
            }

            public HaProxyConfig1Case Set(HaProxyConfig1 value)
            {
                _value = value;
                return this;
            }

            public HaProxyConfig1 Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<V1LbConfigCase, V1LbConfig>))]
        private sealed class V1LbConfigCase : DefaultLbTypeDetails, ICaseValue<V1LbConfigCase, V1LbConfig>
        {
            public V1LbConfig _value;

            public override T Match<T>(Func<HaProxyConfig1, T> haProxyConfig1, Func<V1LbConfig, T> v1LbConfig)
            {
                return v1LbConfig(_value);
            }

            public V1LbConfigCase Set(V1LbConfig value)
            {
                _value = value;
                return this;
            }

            public V1LbConfig Get()
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