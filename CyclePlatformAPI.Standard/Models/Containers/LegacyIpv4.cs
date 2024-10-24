// <copyright file="LegacyIpv4.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<LegacyIpv4>),
        new Type[] {
            typeof(IPNetCase)
        },
        false
    )]
    public abstract class LegacyIpv4
    {
        /// <summary>
        /// This is IPNet case.
        /// </summary>
        /// <returns>
        /// The LegacyIpv4 instance, wrapping the provided IPNet value.
        /// </returns>
        public static LegacyIpv4 FromIPNet(IPNet iPNet)
        {
            return new IPNetCase().Set(iPNet);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<IPNet, T> iPNet);

        [JsonConverter(typeof(UnionTypeCaseConverter<IPNetCase, IPNet>))]
        private sealed class IPNetCase : LegacyIpv4, ICaseValue<IPNetCase, IPNet>
        {
            public IPNet _value;

            public override T Match<T>(Func<IPNet, T> iPNet)
            {
                return iPNet(_value);
            }

            public IPNetCase Set(IPNet value)
            {
                _value = value;
                return this;
            }

            public IPNet Get()
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