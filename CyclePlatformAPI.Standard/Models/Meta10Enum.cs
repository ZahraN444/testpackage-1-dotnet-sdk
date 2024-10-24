// <copyright file="Meta10Enum.cs" company="APIMatic">
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
    /// Meta10Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Meta10Enum
    {
        /// <summary>
        /// InstancesCount.
        /// </summary>
        [EnumMember(Value = "instances_count")]
        InstancesCount,

        /// <summary>
        /// Domains.
        /// </summary>
        [EnumMember(Value = "domains")]
        Domains,

        /// <summary>
        /// Ips.
        /// </summary>
        [EnumMember(Value = "ips")]
        Ips
    }
}