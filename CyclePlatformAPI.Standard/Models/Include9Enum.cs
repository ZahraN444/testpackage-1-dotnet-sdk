// <copyright file="Include9Enum.cs" company="APIMatic">
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
    /// Include9Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Include9Enum
    {
        /// <summary>
        /// Location.
        /// </summary>
        [EnumMember(Value = "location")]
        Location,

        /// <summary>
        /// Models.
        /// </summary>
        [EnumMember(Value = "models")]
        Models,

        /// <summary>
        /// Integrations.
        /// </summary>
        [EnumMember(Value = "integrations")]
        Integrations
    }
}