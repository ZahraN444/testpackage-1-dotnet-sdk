// <copyright file="ServiceContainerIdentifier1Enum.cs" company="APIMatic">
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
    /// ServiceContainerIdentifier1Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ServiceContainerIdentifier1Enum
    {
        /// <summary>
        /// Discovery.
        /// </summary>
        [EnumMember(Value = "discovery")]
        Discovery,

        /// <summary>
        /// Vpn.
        /// </summary>
        [EnumMember(Value = "vpn")]
        Vpn,

        /// <summary>
        /// Loadbalancer.
        /// </summary>
        [EnumMember(Value = "loadbalancer")]
        Loadbalancer,

        /// <summary>
        /// Scheduler.
        /// </summary>
        [EnumMember(Value = "scheduler")]
        Scheduler
    }
}