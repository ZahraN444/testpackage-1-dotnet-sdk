// <copyright file="EnvironmentPrivateNetwork.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<EnvironmentPrivateNetwork>),
        new Type[] {
            typeof(PrivateNetworkCase)
        },
        false
    )]
    public abstract class EnvironmentPrivateNetwork
    {
        /// <summary>
        /// This is PrivateNetwork case.
        /// </summary>
        /// <returns>
        /// The EnvironmentPrivateNetwork instance, wrapping the provided PrivateNetwork value.
        /// </returns>
        public static EnvironmentPrivateNetwork FromPrivateNetwork(PrivateNetwork privateNetwork)
        {
            return new PrivateNetworkCase().Set(privateNetwork);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<PrivateNetwork, T> privateNetwork);

        [JsonConverter(typeof(UnionTypeCaseConverter<PrivateNetworkCase, PrivateNetwork>))]
        private sealed class PrivateNetworkCase : EnvironmentPrivateNetwork, ICaseValue<PrivateNetworkCase, PrivateNetwork>
        {
            public PrivateNetwork _value;

            public override T Match<T>(Func<PrivateNetwork, T> privateNetwork)
            {
                return privateNetwork(_value);
            }

            public PrivateNetworkCase Set(PrivateNetwork value)
            {
                _value = value;
                return this;
            }

            public PrivateNetwork Get()
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