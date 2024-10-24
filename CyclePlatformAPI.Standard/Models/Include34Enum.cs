// <copyright file="Include34Enum.cs" company="APIMatic">
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
    /// Include34Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Include34Enum
    {
        /// <summary>
        /// Creators.
        /// </summary>
        [EnumMember(Value = "creators")]
        Creators,

        /// <summary>
        /// Environments.
        /// </summary>
        [EnumMember(Value = "environments")]
        Environments
    }
}