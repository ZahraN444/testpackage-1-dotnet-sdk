// <copyright file="Include25Enum.cs" company="APIMatic">
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
    /// Include25Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Include25Enum
    {
        /// <summary>
        /// Integrations.
        /// </summary>
        [EnumMember(Value = "integrations")]
        Integrations,

        /// <summary>
        /// Models.
        /// </summary>
        [EnumMember(Value = "models")]
        Models,

        /// <summary>
        /// Locations.
        /// </summary>
        [EnumMember(Value = "locations")]
        Locations
    }
}