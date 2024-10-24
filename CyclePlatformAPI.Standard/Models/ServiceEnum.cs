// <copyright file="ServiceEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using APIMatic.Core.Utilities.Converters;
using CyclePlatformAPI.Standard;
using CyclePlatformAPI.Standard.Utilities;
using Newtonsoft.Json;

namespace CyclePlatformAPI.Standard.Models
{
    /// <summary>
    /// ServiceEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ServiceEnum
    {
        /// <summary>
        /// Discovery.
        /// </summary>
        [EnumMember(Value = "discovery")]
        Discovery,

        /// <summary>
        /// Loadbalancer.
        /// </summary>
        [EnumMember(Value = "loadbalancer")]
        Loadbalancer,

        /// <summary>
        /// Vpn.
        /// </summary>
        [EnumMember(Value = "vpn")]
        Vpn
    }
}