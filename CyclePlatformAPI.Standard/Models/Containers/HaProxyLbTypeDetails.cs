// <copyright file="HaProxyLbTypeDetails.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<HaProxyLbTypeDetails>),
        new Type[] {
            typeof(HaProxyConfig1Case)
        },
        false
    )]
    public abstract class HaProxyLbTypeDetails
    {
        /// <summary>
        /// This is HaProxyConfig1 case.
        /// </summary>
        /// <returns>
        /// The HaProxyLbTypeDetails instance, wrapping the provided HaProxyConfig1 value.
        /// </returns>
        public static HaProxyLbTypeDetails FromHaProxyConfig1(HaProxyConfig1 haProxyConfig1)
        {
            return new HaProxyConfig1Case().Set(haProxyConfig1);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<HaProxyConfig1, T> haProxyConfig1);

        [JsonConverter(typeof(UnionTypeCaseConverter<HaProxyConfig1Case, HaProxyConfig1>))]
        private sealed class HaProxyConfig1Case : HaProxyLbTypeDetails, ICaseValue<HaProxyConfig1Case, HaProxyConfig1>
        {
            public HaProxyConfig1 _value;

            public override T Match<T>(Func<HaProxyConfig1, T> haProxyConfig1)
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
    }
}