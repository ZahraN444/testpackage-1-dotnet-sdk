// <copyright file="Current33Enum.cs" company="APIMatic">
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
    /// Current33Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Current33Enum
    {
        /// <summary>
        /// Pending.
        /// </summary>
        [EnumMember(Value = "pending")]
        Pending,

        /// <summary>
        /// Error.
        /// </summary>
        [EnumMember(Value = "error")]
        Error,

        /// <summary>
        /// Running.
        /// </summary>
        [EnumMember(Value = "running")]
        Running,

        /// <summary>
        /// Completed.
        /// </summary>
        [EnumMember(Value = "completed")]
        Completed
    }
}