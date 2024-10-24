// <copyright file="Current26Enum.cs" company="APIMatic">
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
    /// Current26Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Current26Enum
    {
        /// <summary>
        /// Live.
        /// </summary>
        [EnumMember(Value = "live")]
        Live,

        /// <summary>
        /// Releasing.
        /// </summary>
        [EnumMember(Value = "releasing")]
        Releasing,

        /// <summary>
        /// Released.
        /// </summary>
        [EnumMember(Value = "released")]
        Released
    }
}