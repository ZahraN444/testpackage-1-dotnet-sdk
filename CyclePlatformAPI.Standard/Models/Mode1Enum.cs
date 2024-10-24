// <copyright file="Mode1Enum.cs" company="APIMatic">
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
    /// Mode1Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Mode1Enum
    {
        /// <summary>
        /// Random.
        /// </summary>
        [EnumMember(Value = "random")]
        Random,

        /// <summary>
        /// Roundrobin.
        /// </summary>
        [EnumMember(Value = "round-robin")]
        Roundrobin
    }
}