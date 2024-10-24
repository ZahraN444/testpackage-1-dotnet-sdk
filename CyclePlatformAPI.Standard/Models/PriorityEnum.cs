// <copyright file="PriorityEnum.cs" company="APIMatic">
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
    /// PriorityEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PriorityEnum
    {
        /// <summary>
        /// Notice.
        /// </summary>
        [EnumMember(Value = "notice")]
        Notice,

        /// <summary>
        /// Low.
        /// </summary>
        [EnumMember(Value = "low")]
        Low,

        /// <summary>
        /// Medium.
        /// </summary>
        [EnumMember(Value = "medium")]
        Medium,

        /// <summary>
        /// High.
        /// </summary>
        [EnumMember(Value = "high")]
        High,

        /// <summary>
        /// Severe.
        /// </summary>
        [EnumMember(Value = "severe")]
        Severe
    }
}