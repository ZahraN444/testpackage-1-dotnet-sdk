// <copyright file="Include30Enum.cs" company="APIMatic">
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
    /// Include30Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Include30Enum
    {
        /// <summary>
        /// Servers.
        /// </summary>
        [EnumMember(Value = "servers")]
        Servers,

        /// <summary>
        /// Integrations.
        /// </summary>
        [EnumMember(Value = "integrations")]
        Integrations,

        /// <summary>
        /// Locations.
        /// </summary>
        [EnumMember(Value = "locations")]
        Locations
    }
}