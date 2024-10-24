// <copyright file="Algorithm1Enum.cs" company="APIMatic">
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
    /// Algorithm1Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Algorithm1Enum
    {
        /// <summary>
        /// Raw.
        /// </summary>
        [EnumMember(Value = "raw")]
        Raw,

        /// <summary>
        /// Sha512.
        /// </summary>
        [EnumMember(Value = "sha512")]
        Sha512,

        /// <summary>
        /// Md5.
        /// </summary>
        [EnumMember(Value = "md5")]
        Md5
    }
}