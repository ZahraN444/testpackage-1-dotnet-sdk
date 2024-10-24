// <copyright file="Current1Enum.cs" company="APIMatic">
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
    /// Current1Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Current1Enum
    {
        /// <summary>
        /// Pending.
        /// </summary>
        [EnumMember(Value = "pending")]
        Pending,

        /// <summary>
        /// Accepted.
        /// </summary>
        [EnumMember(Value = "accepted")]
        Accepted,

        /// <summary>
        /// Declined.
        /// </summary>
        [EnumMember(Value = "declined")]
        Declined,

        /// <summary>
        /// Revoked.
        /// </summary>
        [EnumMember(Value = "revoked")]
        Revoked,

        /// <summary>
        /// Deleted.
        /// </summary>
        [EnumMember(Value = "deleted")]
        Deleted
    }
}