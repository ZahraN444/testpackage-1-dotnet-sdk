// <copyright file="BalanceEnum.cs" company="APIMatic">
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
    /// BalanceEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BalanceEnum
    {
        /// <summary>
        /// Roundrobin.
        /// </summary>
        [EnumMember(Value = "roundrobin")]
        Roundrobin,

        /// <summary>
        /// Staticrr.
        /// </summary>
        [EnumMember(Value = "static-rr")]
        Staticrr,

        /// <summary>
        /// Leastconn.
        /// </summary>
        [EnumMember(Value = "leastconn")]
        Leastconn,

        /// <summary>
        /// First.
        /// </summary>
        [EnumMember(Value = "first")]
        First,

        /// <summary>
        /// Source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source
    }
}