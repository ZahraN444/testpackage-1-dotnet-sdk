// <copyright file="Meta30Enum.cs" company="APIMatic">
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
    /// Meta30Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Meta30Enum
    {
        /// <summary>
        /// ContainersCount.
        /// </summary>
        [EnumMember(Value = "containers_count")]
        ContainersCount,

        /// <summary>
        /// BuildsCount.
        /// </summary>
        [EnumMember(Value = "builds_count")]
        BuildsCount
    }
}