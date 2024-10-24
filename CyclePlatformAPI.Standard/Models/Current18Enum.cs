// <copyright file="Current18Enum.cs" company="APIMatic">
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
    /// Current18Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Current18Enum
    {
        /// <summary>
        /// Assigning.
        /// </summary>
        [EnumMember(Value = "assigning")]
        Assigning,

        /// <summary>
        /// Assigned.
        /// </summary>
        [EnumMember(Value = "assigned")]
        Assigned,

        /// <summary>
        /// Releasing.
        /// </summary>
        [EnumMember(Value = "releasing")]
        Releasing,

        /// <summary>
        /// Available.
        /// </summary>
        [EnumMember(Value = "available")]
        Available
    }
}