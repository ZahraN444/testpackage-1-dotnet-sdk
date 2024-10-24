// <copyright file="Include7Enum.cs" company="APIMatic">
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
    /// Include7Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Include7Enum
    {
        /// <summary>
        /// Creators.
        /// </summary>
        [EnumMember(Value = "creators")]
        Creators,

        /// <summary>
        /// Servers.
        /// </summary>
        [EnumMember(Value = "servers")]
        Servers,

        /// <summary>
        /// Locations.
        /// </summary>
        [EnumMember(Value = "locations")]
        Locations,

        /// <summary>
        /// Integrations.
        /// </summary>
        [EnumMember(Value = "integrations")]
        Integrations,

        /// <summary>
        /// Containers.
        /// </summary>
        [EnumMember(Value = "containers")]
        Containers,

        /// <summary>
        /// Environments.
        /// </summary>
        [EnumMember(Value = "environments")]
        Environments
    }
}