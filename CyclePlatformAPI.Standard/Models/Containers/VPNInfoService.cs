// <copyright file="VPNInfoService.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<VPNInfoService>),
        new Type[] {
            typeof(VpnEnvironmentServiceCase)
        },
        false
    )]
    public abstract class VPNInfoService
    {
        /// <summary>
        /// This is VpnEnvironmentService case.
        /// </summary>
        /// <returns>
        /// The VPNInfoService instance, wrapping the provided VpnEnvironmentService value.
        /// </returns>
        public static VPNInfoService FromVpnEnvironmentService(VpnEnvironmentService vpnEnvironmentService)
        {
            return new VpnEnvironmentServiceCase().Set(vpnEnvironmentService);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<VpnEnvironmentService, T> vpnEnvironmentService);

        [JsonConverter(typeof(UnionTypeCaseConverter<VpnEnvironmentServiceCase, VpnEnvironmentService>))]
        private sealed class VpnEnvironmentServiceCase : VPNInfoService, ICaseValue<VpnEnvironmentServiceCase, VpnEnvironmentService>
        {
            public VpnEnvironmentService _value;

            public override T Match<T>(Func<VpnEnvironmentService, T> vpnEnvironmentService)
            {
                return vpnEnvironmentService(_value);
            }

            public VpnEnvironmentServiceCase Set(VpnEnvironmentService value)
            {
                _value = value;
                return this;
            }

            public VpnEnvironmentService Get()
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