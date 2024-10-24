// <copyright file="Status1Enum.cs" company="APIMatic">
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
    /// Status1Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Status1Enum
    {
        /// <summary>
        /// Info.
        /// </summary>
        [EnumMember(Value = "info")]
        Info,

        /// <summary>
        /// Warn.
        /// </summary>
        [EnumMember(Value = "warn")]
        Warn,

        /// <summary>
        /// Request.
        /// </summary>
        [EnumMember(Value = "request")]
        Request,

        /// <summary>
        /// Success.
        /// </summary>
        [EnumMember(Value = "success")]
        Success,

        /// <summary>
        /// Error.
        /// </summary>
        [EnumMember(Value = "error")]
        Error,

        /// <summary>
        /// Alert.
        /// </summary>
        [EnumMember(Value = "alert")]
        Alert
    }
}