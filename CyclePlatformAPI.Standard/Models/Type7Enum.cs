// <copyright file="Type7Enum.cs" company="APIMatic">
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
    /// Type7Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type7Enum
    {
        /// <summary>
        /// Hash.
        /// </summary>
        [EnumMember(Value = "hash")]
        Hash,

        /// <summary>
        /// Tag.
        /// </summary>
        [EnumMember(Value = "tag")]
        Tag,

        /// <summary>
        /// Branch.
        /// </summary>
        [EnumMember(Value = "branch")]
        Branch
    }
}