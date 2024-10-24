// <copyright file="Current14Enum.cs" company="APIMatic">
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
    /// Current14Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Current14Enum
    {
        /// <summary>
        /// Live.
        /// </summary>
        [EnumMember(Value = "live")]
        Live,

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