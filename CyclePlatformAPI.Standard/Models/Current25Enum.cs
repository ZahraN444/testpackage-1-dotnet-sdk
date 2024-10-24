// <copyright file="Current25Enum.cs" company="APIMatic">
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
    /// Current25Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Current25Enum
    {
        /// <summary>
        /// New.
        /// </summary>
        [EnumMember(Value = "new")]
        New,

        /// <summary>
        /// Pending.
        /// </summary>
        [EnumMember(Value = "pending")]
        Pending,

        /// <summary>
        /// Verifying.
        /// </summary>
        [EnumMember(Value = "verifying")]
        Verifying,

        /// <summary>
        /// Live.
        /// </summary>
        [EnumMember(Value = "live")]
        Live,

        /// <summary>
        /// Disabled.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,

        /// <summary>
        /// Deleting.
        /// </summary>
        [EnumMember(Value = "deleting")]
        Deleting,

        /// <summary>
        /// Deleted.
        /// </summary>
        [EnumMember(Value = "deleted")]
        Deleted
    }
}