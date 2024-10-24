// <copyright file="NetworkPrivateNetwork.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<NetworkPrivateNetwork>),
        new Type[] {
            typeof(NetworkPrivacySettingsCase)
        },
        false
    )]
    public abstract class NetworkPrivateNetwork
    {
        /// <summary>
        /// This is NetworkPrivacySettings case.
        /// </summary>
        /// <returns>
        /// The NetworkPrivateNetwork instance, wrapping the provided NetworkPrivacySettings value.
        /// </returns>
        public static NetworkPrivateNetwork FromNetworkPrivacySettings(NetworkPrivacySettings networkPrivacySettings)
        {
            return new NetworkPrivacySettingsCase().Set(networkPrivacySettings);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<NetworkPrivacySettings, T> networkPrivacySettings);

        [JsonConverter(typeof(UnionTypeCaseConverter<NetworkPrivacySettingsCase, NetworkPrivacySettings>))]
        private sealed class NetworkPrivacySettingsCase : NetworkPrivateNetwork, ICaseValue<NetworkPrivacySettingsCase, NetworkPrivacySettings>
        {
            public NetworkPrivacySettings _value;

            public override T Match<T>(Func<NetworkPrivacySettings, T> networkPrivacySettings)
            {
                return networkPrivacySettings(_value);
            }

            public NetworkPrivacySettingsCase Set(NetworkPrivacySettings value)
            {
                _value = value;
                return this;
            }

            public NetworkPrivacySettings Get()
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