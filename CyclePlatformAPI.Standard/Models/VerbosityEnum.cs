// <copyright file="VerbosityEnum.cs" company="APIMatic">
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
    /// VerbosityEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum VerbosityEnum
    {
        /// <summary>
        /// Low.
        /// </summary>
        [EnumMember(Value = "low")]
        Low,

        /// <summary>
        /// Normal.
        /// </summary>
        [EnumMember(Value = "normal")]
        Normal,

        /// <summary>
        /// High.
        /// </summary>
        [EnumMember(Value = "high")]
        High,

        /// <summary>
        /// Debug.
        /// </summary>
        [EnumMember(Value = "debug")]
        Debug
    }
}