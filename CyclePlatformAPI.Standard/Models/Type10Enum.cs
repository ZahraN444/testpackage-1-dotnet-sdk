// <copyright file="Type10Enum.cs" company="APIMatic">
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
    /// Type10Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type10Enum
    {
        /// <summary>
        /// Bucket.
        /// </summary>
        [EnumMember(Value = "bucket")]
        Bucket
    }
}