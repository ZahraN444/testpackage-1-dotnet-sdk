// <copyright file="Meta24Enum.cs" company="APIMatic">
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
    /// Meta24Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Meta24Enum
    {
        /// <summary>
        /// ContainersCount.
        /// </summary>
        [EnumMember(Value = "containers_count")]
        ContainersCount
    }
}