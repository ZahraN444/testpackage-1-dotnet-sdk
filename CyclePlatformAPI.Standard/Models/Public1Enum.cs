// <copyright file="Public1Enum.cs" company="APIMatic">
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
    /// Public1Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Public1Enum
    {
        /// <summary>
        /// Enable.
        /// </summary>
        [EnumMember(Value = "enable")]
        Enable,

        /// <summary>
        /// Egressonly.
        /// </summary>
        [EnumMember(Value = "egress-only")]
        Egressonly,

        /// <summary>
        /// Disable.
        /// </summary>
        [EnumMember(Value = "disable")]
        Disable
    }
}