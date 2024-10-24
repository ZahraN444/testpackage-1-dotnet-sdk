// <copyright file="Include4Enum.cs" company="APIMatic">
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
    /// Include4Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Include4Enum
    {
        /// <summary>
        /// Instances.
        /// </summary>
        [EnumMember(Value = "instances")]
        Instances,

        /// <summary>
        /// Servers.
        /// </summary>
        [EnumMember(Value = "servers")]
        Servers,

        /// <summary>
        /// Containers.
        /// </summary>
        [EnumMember(Value = "containers")]
        Containers
    }
}