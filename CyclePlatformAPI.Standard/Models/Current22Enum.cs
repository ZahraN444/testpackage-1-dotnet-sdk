// <copyright file="Current22Enum.cs" company="APIMatic">
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
    /// Current22Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Current22Enum
    {
        /// <summary>
        /// New.
        /// </summary>
        [EnumMember(Value = "new")]
        New,

        /// <summary>
        /// Offline.
        /// </summary>
        [EnumMember(Value = "offline")]
        Offline,

        /// <summary>
        /// Authorizing.
        /// </summary>
        [EnumMember(Value = "authorizing")]
        Authorizing,

        /// <summary>
        /// Online.
        /// </summary>
        [EnumMember(Value = "online")]
        Online,

        /// <summary>
        /// Decommissioned.
        /// </summary>
        [EnumMember(Value = "decommissioned")]
        Decommissioned
    }
}