// <copyright file="Kind1Enum.cs" company="APIMatic">
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
    /// Kind1Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Kind1Enum
    {
        /// <summary>
        /// Ipv4.
        /// </summary>
        [EnumMember(Value = "ipv4")]
        Ipv4,

        /// <summary>
        /// Ipv6.
        /// </summary>
        [EnumMember(Value = "ipv6")]
        Ipv6
    }
}