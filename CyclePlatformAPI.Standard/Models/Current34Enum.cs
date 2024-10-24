// <copyright file="Current34Enum.cs" company="APIMatic">
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
    /// Current34Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Current34Enum
    {
        /// <summary>
        /// New.
        /// </summary>
        [EnumMember(Value = "new")]
        New,

        /// <summary>
        /// Queued.
        /// </summary>
        [EnumMember(Value = "queued")]
        Queued,

        /// <summary>
        /// Error.
        /// </summary>
        [EnumMember(Value = "error")]
        Error,

        /// <summary>
        /// Scheduled.
        /// </summary>
        [EnumMember(Value = "scheduled")]
        Scheduled,

        /// <summary>
        /// Expired.
        /// </summary>
        [EnumMember(Value = "expired")]
        Expired,

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