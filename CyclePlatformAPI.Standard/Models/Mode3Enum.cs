// <copyright file="Mode3Enum.cs" company="APIMatic">
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
    /// Mode3Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Mode3Enum
    {
        /// <summary>
        /// Ro.
        /// </summary>
        [EnumMember(Value = "ro")]
        Ro,

        /// <summary>
        /// Rw.
        /// </summary>
        [EnumMember(Value = "rw")]
        Rw
    }
}