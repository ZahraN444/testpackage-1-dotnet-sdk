// <copyright file="Range2Enum.cs" company="APIMatic">
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
    /// Range2Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Range2Enum
    {
        /// <summary>
        /// Hour.
        /// </summary>
        [EnumMember(Value = "hour")]
        Hour,

        /// <summary>
        /// Day.
        /// </summary>
        [EnumMember(Value = "day")]
        Day,

        /// <summary>
        /// Week.
        /// </summary>
        [EnumMember(Value = "week")]
        Week,

        /// <summary>
        /// Month.
        /// </summary>
        [EnumMember(Value = "month")]
        Month,

        /// <summary>
        /// Year.
        /// </summary>
        [EnumMember(Value = "year")]
        Year
    }
}