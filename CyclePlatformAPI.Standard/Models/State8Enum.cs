// <copyright file="State8Enum.cs" company="APIMatic">
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
    /// State8Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum State8Enum
    {
        /// <summary>
        /// None.
        /// </summary>
        [EnumMember(Value = "none")]
        None,

        /// <summary>
        /// Unknown.
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown,

        /// <summary>
        /// Unreachable.
        /// </summary>
        [EnumMember(Value = "unreachable")]
        Unreachable,

        /// <summary>
        /// Flux.
        /// </summary>
        [EnumMember(Value = "flux")]
        Flux,

        /// <summary>
        /// Recovered.
        /// </summary>
        [EnumMember(Value = "recovered")]
        Recovered
    }
}