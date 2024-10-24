// <copyright file="Include38Enum.cs" company="APIMatic">
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
    /// Include38Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Include38Enum
    {
        /// <summary>
        /// Creators.
        /// </summary>
        [EnumMember(Value = "creators")]
        Creators,

        /// <summary>
        /// Name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,

        /// <summary>
        /// Components.
        /// </summary>
        [EnumMember(Value = "components")]
        Components
    }
}