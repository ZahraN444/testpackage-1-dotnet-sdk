// <copyright file="V1LbTypeDetails.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<V1LbTypeDetails>),
        new Type[] {
            typeof(V1LbConfigCase)
        },
        false
    )]
    public abstract class V1LbTypeDetails
    {
        /// <summary>
        /// This is V1LbConfig case.
        /// </summary>
        /// <returns>
        /// The V1LbTypeDetails instance, wrapping the provided V1LbConfig value.
        /// </returns>
        public static V1LbTypeDetails FromV1LbConfig(V1LbConfig v1LbConfig)
        {
            return new V1LbConfigCase().Set(v1LbConfig);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<V1LbConfig, T> v1LbConfig);

        [JsonConverter(typeof(UnionTypeCaseConverter<V1LbConfigCase, V1LbConfig>))]
        private sealed class V1LbConfigCase : V1LbTypeDetails, ICaseValue<V1LbConfigCase, V1LbConfig>
        {
            public V1LbConfig _value;

            public override T Match<T>(Func<V1LbConfig, T> v1LbConfig)
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